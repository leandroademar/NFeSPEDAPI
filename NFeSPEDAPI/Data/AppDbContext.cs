using Microsoft.EntityFrameworkCore;
using NFeSPEDAPI.Models.NFe;
using NFeSPEDAPI.Models.SPED;

namespace NFeSPEDAPI.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<NFeModel> NFes { get; set; }
    public DbSet<NFeItemModel> NFeItens { get; set; }
    public DbSet<SpedModel> SpedArquivos { get; set; }
    public DbSet<SpedBlocoModel> SpedBlocos { get; set; }
    public DbSet<SpedRegistroModel> SpedRegistros { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configurações adicionais do EF Core
        modelBuilder.Entity<NFeItemModel>()
            .HasOne(i => i.NFe)
            .WithMany(n => n.Itens)
            .HasForeignKey(i => i.NFeId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<SpedBlocoModel>()
            .HasOne(b => b.Sped)
            .WithMany(s => s.Blocos)
            .HasForeignKey(b => b.SpedId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<SpedRegistroModel>()
            .HasOne(r => r.Bloco)
            .WithMany(b => b.Registros)
            .HasForeignKey(r => r.BlocoId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}