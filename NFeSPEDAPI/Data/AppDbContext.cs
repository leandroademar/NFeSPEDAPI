using System;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using NFeSPEDAPI.Models.NFe;
using EficazFramework.SPED.Schemas.Primitives;
using NFeSPEDAPI.Models.SPED.Blocos.Bloco_0;

namespace NFeSPEDAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<NFeModel> NFes { get; set; }
        public DbSet<NFeItemModel> NFeItens { get; set; }
        
        
        public DbSet<Registro0000> Registro0000 { get; set; }
        public DbSet<Registro0001> Registro0001 { get; set; }
        public DbSet<Registro0005> Registro0005 { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurações de relacionamentos dos seus modelos
            modelBuilder.Entity<NFeItemModel>()
                .HasOne(i => i.NFe)
                .WithMany(n => n.Itens)
                .HasForeignKey(i => i.NFeId)
                .OnDelete(DeleteBehavior.Cascade);

            // Converte todos os nomes de tabelas para lowercase
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                // Converte o nome da tabela para lowercase
                    entityType.SetTableName(entityType.GetTableName().ToLower());
                
                
                // Converte o nome de todas as colunas para lowercase (opcional)
                foreach (var property in entityType.GetProperties())
                {
                    property.SetColumnName(property.GetColumnName().ToLower());
                }
            }

            // Tipo base está na biblioteca EficazFramework.SPED.Schemas.Primitives
            var registroBaseType = typeof(Registro);

            // Busca em todos os assemblies carregados
            var registroEntities = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => {
                    try { 
                        return a.GetTypes(); 
                    } 
                    catch (ReflectionTypeLoadException) { 
                        return Type.EmptyTypes; 
                    }
                })
                .Where(t => t.IsClass 
                         && !t.IsAbstract 
                         && registroBaseType.IsAssignableFrom(t)
                         && t.Namespace?.StartsWith("NFeSPEDAPI.Models.SPED") == true);

            // Para cada entidade, configura a chave primária e o nome da tabela em lowercase
            foreach (var entityType in registroEntities)
            {
                try
                {
                    // Verifica se a entidade tem um construtor sem parâmetros
                    bool hasParameterlessConstructor = entityType.GetConstructor(Type.EmptyTypes) != null;
                    
                    if (hasParameterlessConstructor)
                    {
                        // Configura como entidade normal com chave primária
                        var entityBuilder = modelBuilder.Entity(entityType);
                        
                        entityBuilder
                            .Property<int>("id")
                            .ValueGeneratedOnAdd();
                        
                        entityBuilder
                            .Property<string>("datafile")
                            .ValueGeneratedOnAdd();
                        
                        entityBuilder
                            .HasKey("id", "datafile");
                        
                        // Define o nome da tabela em lowercase
                        string tableName = entityType.Name.ToLower();
                        entityBuilder.ToTable(tableName);
                        
                    }
                    else
                    {
                        // Para entidades sem construtor sem parâmetros, configura como entidade sem chave
                        var entityBuilder = modelBuilder.Entity(entityType);
                        entityBuilder.HasNoKey();
                        
                        // Define o nome da tabela em lowercase
                        string tableName = entityType.Name.ToLower();
                        entityBuilder.ToTable(tableName);
                    }
                }
                catch (Exception ex)
                {
                    // Log da exceção para diagnóstico
                    Console.WriteLine($"Erro ao configurar entidade {entityType.Name}: {ex.Message}");
                }
            }
        }
    }
}