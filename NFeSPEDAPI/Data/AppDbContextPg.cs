using Microsoft.EntityFrameworkCore;
using NFeSPEDAPI.Models.NFe;
using NFeSPEDAPI.Models.Sped;

namespace NFeSPEDAPI.Data;

public partial class AppDbContextPg : DbContext
{
    public AppDbContextPg(DbContextOptions<AppDbContextPg> options)
        : base(options)
    {
    }
    
    public DbSet<NFeModel> NFes { get; set; }
    public DbSet<NFeItemModel> NFeItens { get; set; }

    public virtual DbSet<Contribuinte> Contribuintes { get; set; }

    public virtual DbSet<Escrituracaofiscal> Escrituracaofiscals { get; set; }

    public virtual DbSet<Inconsistencium> Inconsistencia { get; set; }

    public virtual DbSet<Oie> Oies { get; set; }

    public virtual DbSet<Reg0001> Reg0001s { get; set; }

    public virtual DbSet<Reg0002> Reg0002s { get; set; }

    public virtual DbSet<Reg0005> Reg0005s { get; set; }

    public virtual DbSet<Reg0015> Reg0015s { get; set; }

    public virtual DbSet<Reg0100> Reg0100s { get; set; }

    public virtual DbSet<Reg0150> Reg0150s { get; set; }

    public virtual DbSet<Reg0175> Reg0175s { get; set; }

    public virtual DbSet<Reg0190> Reg0190s { get; set; }

    public virtual DbSet<Reg0200> Reg0200s { get; set; }

    public virtual DbSet<Reg0205> Reg0205s { get; set; }

    public virtual DbSet<Reg0206> Reg0206s { get; set; }

    public virtual DbSet<Reg0220> Reg0220s { get; set; }

    public virtual DbSet<Reg0221> Reg0221s { get; set; }

    public virtual DbSet<Reg0300> Reg0300s { get; set; }

    public virtual DbSet<Reg0305> Reg0305s { get; set; }

    public virtual DbSet<Reg0400> Reg0400s { get; set; }

    public virtual DbSet<Reg0450> Reg0450s { get; set; }

    public virtual DbSet<Reg0460> Reg0460s { get; set; }

    public virtual DbSet<Reg0500> Reg0500s { get; set; }

    public virtual DbSet<Reg0600> Reg0600s { get; set; }

    public virtual DbSet<Reg0990> Reg0990s { get; set; }

    public virtual DbSet<Reg1001> Reg1001s { get; set; }

    public virtual DbSet<Reg1010> Reg1010s { get; set; }

    public virtual DbSet<Reg1100> Reg1100s { get; set; }

    public virtual DbSet<Reg1105> Reg1105s { get; set; }

    public virtual DbSet<Reg1110> Reg1110s { get; set; }

    public virtual DbSet<Reg1200> Reg1200s { get; set; }

    public virtual DbSet<Reg1210> Reg1210s { get; set; }

    public virtual DbSet<Reg1250> Reg1250s { get; set; }

    public virtual DbSet<Reg1255> Reg1255s { get; set; }

    public virtual DbSet<Reg1300> Reg1300s { get; set; }

    public virtual DbSet<Reg1310> Reg1310s { get; set; }

    public virtual DbSet<Reg1320> Reg1320s { get; set; }

    public virtual DbSet<Reg1350> Reg1350s { get; set; }

    public virtual DbSet<Reg1360> Reg1360s { get; set; }

    public virtual DbSet<Reg1370> Reg1370s { get; set; }

    public virtual DbSet<Reg1390> Reg1390s { get; set; }

    public virtual DbSet<Reg1391> Reg1391s { get; set; }

    public virtual DbSet<Reg1400> Reg1400s { get; set; }

    public virtual DbSet<Reg1500> Reg1500s { get; set; }

    public virtual DbSet<Reg1510> Reg1510s { get; set; }

    public virtual DbSet<Reg1601> Reg1601s { get; set; }

    public virtual DbSet<Reg1700> Reg1700s { get; set; }

    public virtual DbSet<Reg1710> Reg1710s { get; set; }

    public virtual DbSet<Reg1800> Reg1800s { get; set; }

    public virtual DbSet<Reg1900> Reg1900s { get; set; }

    public virtual DbSet<Reg1910> Reg1910s { get; set; }

    public virtual DbSet<Reg1920> Reg1920s { get; set; }

    public virtual DbSet<Reg1921> Reg1921s { get; set; }

    public virtual DbSet<Reg1922> Reg1922s { get; set; }

    public virtual DbSet<Reg1923> Reg1923s { get; set; }

    public virtual DbSet<Reg1925> Reg1925s { get; set; }

    public virtual DbSet<Reg1926> Reg1926s { get; set; }

    public virtual DbSet<Reg1960> Reg1960s { get; set; }

    public virtual DbSet<Reg1970> Reg1970s { get; set; }

    public virtual DbSet<Reg1975> Reg1975s { get; set; }

    public virtual DbSet<Reg1980> Reg1980s { get; set; }

    public virtual DbSet<Reg1990> Reg1990s { get; set; }

    public virtual DbSet<Reg9001> Reg9001s { get; set; }

    public virtual DbSet<Reg9900> Reg9900s { get; set; }

    public virtual DbSet<Reg9990> Reg9990s { get; set; }

    public virtual DbSet<Reg9999> Reg9999s { get; set; }

    public virtual DbSet<RegB001> RegB001s { get; set; }

    public virtual DbSet<RegB020> RegB020s { get; set; }

    public virtual DbSet<RegB025> RegB025s { get; set; }

    public virtual DbSet<RegB030> RegB030s { get; set; }

    public virtual DbSet<RegB035> RegB035s { get; set; }

    public virtual DbSet<RegB350> RegB350s { get; set; }

    public virtual DbSet<RegB420> RegB420s { get; set; }

    public virtual DbSet<RegB440> RegB440s { get; set; }

    public virtual DbSet<RegB460> RegB460s { get; set; }

    public virtual DbSet<RegB470> RegB470s { get; set; }

    public virtual DbSet<RegB500> RegB500s { get; set; }

    public virtual DbSet<RegB510> RegB510s { get; set; }

    public virtual DbSet<RegB990> RegB990s { get; set; }

    public virtual DbSet<RegC001> RegC001s { get; set; }

    public virtual DbSet<RegC100> RegC100s { get; set; }

    public virtual DbSet<RegC101> RegC101s { get; set; }

    public virtual DbSet<RegC105> RegC105s { get; set; }

    public virtual DbSet<RegC110> RegC110s { get; set; }

    public virtual DbSet<RegC111> RegC111s { get; set; }

    public virtual DbSet<RegC112> RegC112s { get; set; }

    public virtual DbSet<RegC113> RegC113s { get; set; }

    public virtual DbSet<RegC114> RegC114s { get; set; }

    public virtual DbSet<RegC115> RegC115s { get; set; }

    public virtual DbSet<RegC116> RegC116s { get; set; }

    public virtual DbSet<RegC120> RegC120s { get; set; }

    public virtual DbSet<RegC130> RegC130s { get; set; }

    public virtual DbSet<RegC140> RegC140s { get; set; }

    public virtual DbSet<RegC141> RegC141s { get; set; }

    public virtual DbSet<RegC160> RegC160s { get; set; }

    public virtual DbSet<RegC165> RegC165s { get; set; }

    public virtual DbSet<RegC170> RegC170s { get; set; }

    public virtual DbSet<RegC171> RegC171s { get; set; }

    public virtual DbSet<RegC172> RegC172s { get; set; }

    public virtual DbSet<RegC173> RegC173s { get; set; }

    public virtual DbSet<RegC174> RegC174s { get; set; }

    public virtual DbSet<RegC175> RegC175s { get; set; }

    public virtual DbSet<RegC176> RegC176s { get; set; }

    public virtual DbSet<RegC177> RegC177s { get; set; }

    public virtual DbSet<RegC178> RegC178s { get; set; }

    public virtual DbSet<RegC179> RegC179s { get; set; }

    public virtual DbSet<RegC180> RegC180s { get; set; }

    public virtual DbSet<RegC181> RegC181s { get; set; }

    public virtual DbSet<RegC185> RegC185s { get; set; }

    public virtual DbSet<RegC186> RegC186s { get; set; }

    public virtual DbSet<RegC190> RegC190s { get; set; }

    public virtual DbSet<RegC191> RegC191s { get; set; }

    public virtual DbSet<RegC195> RegC195s { get; set; }

    public virtual DbSet<RegC197> RegC197s { get; set; }

    public virtual DbSet<RegC300> RegC300s { get; set; }

    public virtual DbSet<RegC310> RegC310s { get; set; }

    public virtual DbSet<RegC320> RegC320s { get; set; }

    public virtual DbSet<RegC321> RegC321s { get; set; }

    public virtual DbSet<RegC330> RegC330s { get; set; }

    public virtual DbSet<RegC350> RegC350s { get; set; }

    public virtual DbSet<RegC370> RegC370s { get; set; }

    public virtual DbSet<RegC380> RegC380s { get; set; }

    public virtual DbSet<RegC390> RegC390s { get; set; }

    public virtual DbSet<RegC400> RegC400s { get; set; }

    public virtual DbSet<RegC405> RegC405s { get; set; }

    public virtual DbSet<RegC410> RegC410s { get; set; }

    public virtual DbSet<RegC420> RegC420s { get; set; }

    public virtual DbSet<RegC425> RegC425s { get; set; }

    public virtual DbSet<RegC430> RegC430s { get; set; }

    public virtual DbSet<RegC460> RegC460s { get; set; }

    public virtual DbSet<RegC465> RegC465s { get; set; }

    public virtual DbSet<RegC470> RegC470s { get; set; }

    public virtual DbSet<RegC480> RegC480s { get; set; }

    public virtual DbSet<RegC490> RegC490s { get; set; }

    public virtual DbSet<RegC500> RegC500s { get; set; }

    public virtual DbSet<RegC510> RegC510s { get; set; }

    public virtual DbSet<RegC590> RegC590s { get; set; }

    public virtual DbSet<RegC591> RegC591s { get; set; }

    public virtual DbSet<RegC595> RegC595s { get; set; }

    public virtual DbSet<RegC597> RegC597s { get; set; }

    public virtual DbSet<RegC600> RegC600s { get; set; }

    public virtual DbSet<RegC601> RegC601s { get; set; }

    public virtual DbSet<RegC610> RegC610s { get; set; }

    public virtual DbSet<RegC690> RegC690s { get; set; }

    public virtual DbSet<RegC695> RegC695s { get; set; }

    public virtual DbSet<RegC790> RegC790s { get; set; }

    public virtual DbSet<RegC791> RegC791s { get; set; }

    public virtual DbSet<RegC800> RegC800s { get; set; }

    public virtual DbSet<RegC810> RegC810s { get; set; }

    public virtual DbSet<RegC815> RegC815s { get; set; }

    public virtual DbSet<RegC850> RegC850s { get; set; }

    public virtual DbSet<RegC855> RegC855s { get; set; }

    public virtual DbSet<RegC857> RegC857s { get; set; }

    public virtual DbSet<RegC860> RegC860s { get; set; }

    public virtual DbSet<RegC870> RegC870s { get; set; }

    public virtual DbSet<RegC880> RegC880s { get; set; }

    public virtual DbSet<RegC890> RegC890s { get; set; }

    public virtual DbSet<RegC895> RegC895s { get; set; }

    public virtual DbSet<RegC897> RegC897s { get; set; }

    public virtual DbSet<RegD001> RegD001s { get; set; }

    public virtual DbSet<RegD100> RegD100s { get; set; }

    public virtual DbSet<TabelaUf> TabelaUfs { get; set; }

    public virtual DbSet<Tabelaexternareferenciadum> Tabelaexternareferenciada { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasPostgresEnum("auth", "aal_level", new[] { "aal1", "aal2", "aal3" })
            .HasPostgresEnum("auth", "code_challenge_method", new[] { "s256", "plain" })
            .HasPostgresEnum("auth", "factor_status", new[] { "unverified", "verified" })
            .HasPostgresEnum("auth", "factor_type", new[] { "totp", "webauthn", "phone" })
            .HasPostgresEnum("auth", "one_time_token_type", new[] { "confirmation_token", "reauthentication_token", "recovery_token", "email_change_token_new", "email_change_token_current", "phone_change_token" })
            .HasPostgresEnum("net", "request_status", new[] { "PENDING", "SUCCESS", "ERROR" })
            .HasPostgresEnum("realtime", "action", new[] { "INSERT", "UPDATE", "DELETE", "TRUNCATE", "ERROR" })
            .HasPostgresEnum("realtime", "equality_op", new[] { "eq", "neq", "lt", "lte", "gt", "gte", "in" })
            .HasPostgresExtension("extensions", "pg_net")
            .HasPostgresExtension("extensions", "pg_stat_statements")
            .HasPostgresExtension("extensions", "pgcrypto")
            .HasPostgresExtension("extensions", "pgjwt")
            .HasPostgresExtension("extensions", "uuid-ossp")
            .HasPostgresExtension("graphql", "pg_graphql")
            .HasPostgresExtension("pg_catalog", "pg_cron")
            .HasPostgresExtension("vault", "supabase_vault");

        modelBuilder.Entity<Contribuinte>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("contribuinte_pkey");

            entity.Property(e => e.CodMun).IsFixedLength();
            entity.Property(e => e.Suframa).IsFixedLength();
            entity.Property(e => e.Uf).IsFixedLength();
        });

        modelBuilder.Entity<Escrituracaofiscal>(entity =>
        {
            entity.HasKey(e => e.IdEsct).HasName("escrituracaofiscal_pkey");

            entity.Property(e => e.CodigoMunicipio).IsFixedLength();
            entity.Property(e => e.Uf).IsFixedLength();
        });

        modelBuilder.Entity<Inconsistencium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("inconsistencia_pkey");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Oie>(entity =>
        {
            entity.HasKey(e => e.IdEsct).HasName("oie_pkey");

            entity.Property(e => e.CodigoMunicipio).IsFixedLength();
            entity.Property(e => e.Uf).IsFixedLength();
        });

        modelBuilder.Entity<Reg0001>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_0001_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg0001s).HasConstraintName("reg_0001_fk_esct");
        });

        modelBuilder.Entity<Reg0002>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_0002_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg0002s).HasConstraintName("reg_0002_fk_esct");
        });

        modelBuilder.Entity<Reg0005>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_0005_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg0005s).HasConstraintName("reg_0005_fk_esct");
        });

        modelBuilder.Entity<Reg0015>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_0015_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg0015s).HasConstraintName("reg_0015_fk_esct");
        });

        modelBuilder.Entity<Reg0100>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_0100_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg0100s).HasConstraintName("reg_0100_fk_esct");
        });

        modelBuilder.Entity<Reg0150>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_0150_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg0150s).HasConstraintName("reg_0150_fk_esct");
        });

        modelBuilder.Entity<Reg0175>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_0175_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg0175s).HasConstraintName("reg_0175_fk_esct");
        });

        modelBuilder.Entity<Reg0190>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_0190_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg0190s).HasConstraintName("reg_0190_fk_esct");
        });

        modelBuilder.Entity<Reg0200>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_0200_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg0200s).HasConstraintName("reg_0200_fk_esct");
        });

        modelBuilder.Entity<Reg0205>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_0205_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg0205s).HasConstraintName("reg_0205_fk_esct");
        });

        modelBuilder.Entity<Reg0206>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_0206_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg0206s).HasConstraintName("reg_0206_fk_esct");
        });

        modelBuilder.Entity<Reg0220>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_0220_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg0220s).HasConstraintName("reg_0220_fk_esct");
        });

        modelBuilder.Entity<Reg0221>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_0221_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg0221s).HasConstraintName("reg_0221_fk_esct");
        });

        modelBuilder.Entity<Reg0300>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_0300_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg0300s).HasConstraintName("reg_0300_fk_esct");
        });

        modelBuilder.Entity<Reg0305>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_0305_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg0305s).HasConstraintName("reg_0305_fk_esct");
        });

        modelBuilder.Entity<Reg0400>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_0400_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg0400s).HasConstraintName("reg_0400_fk_esct");
        });

        modelBuilder.Entity<Reg0450>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_0450_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg0450s).HasConstraintName("reg_0450_fk_esct");
        });

        modelBuilder.Entity<Reg0460>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_0460_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg0460s).HasConstraintName("reg_0460_fk_esct");
        });

        modelBuilder.Entity<Reg0500>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_0500_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg0500s).HasConstraintName("reg_0500_fk_esct");
        });

        modelBuilder.Entity<Reg0600>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_0600_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg0600s).HasConstraintName("reg_0600_fk_esct");
        });

        modelBuilder.Entity<Reg0990>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_0990_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg0990s).HasConstraintName("reg_0990_fk_esct");
        });

        modelBuilder.Entity<Reg1001>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1001_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1001s).HasConstraintName("reg_1001_fk_esct");
        });

        modelBuilder.Entity<Reg1010>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1010_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1010s).HasConstraintName("reg_1010_fk_esct");
        });

        modelBuilder.Entity<Reg1100>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1100_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1100s).HasConstraintName("reg_1100_fk_esct");
        });

        modelBuilder.Entity<Reg1105>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1105_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1105s).HasConstraintName("reg_1105_fk_esct");
        });

        modelBuilder.Entity<Reg1110>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1110_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1110s).HasConstraintName("reg_1110_fk_esct");
        });

        modelBuilder.Entity<Reg1200>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1200_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1200s).HasConstraintName("reg_1200_fk_esct");
        });

        modelBuilder.Entity<Reg1210>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1210_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1210s).HasConstraintName("reg_1210_fk_esct");
        });

        modelBuilder.Entity<Reg1250>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1250_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1250s).HasConstraintName("reg_1250_fk_esct");
        });

        modelBuilder.Entity<Reg1255>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1255_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1255s).HasConstraintName("reg_1255_fk_esct");
        });

        modelBuilder.Entity<Reg1300>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1300_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1300s).HasConstraintName("reg_1300_fk_esct");
        });

        modelBuilder.Entity<Reg1310>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1310_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1310s).HasConstraintName("reg_1310_fk_esct");
        });

        modelBuilder.Entity<Reg1320>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1320_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1320s).HasConstraintName("reg_1320_fk_esct");
        });

        modelBuilder.Entity<Reg1350>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1350_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1350s).HasConstraintName("reg_1350_fk_esct");
        });

        modelBuilder.Entity<Reg1360>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1360_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1360s).HasConstraintName("reg_1360_fk_esct");
        });

        modelBuilder.Entity<Reg1370>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1370_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1370s).HasConstraintName("reg_1370_fk_esct");
        });

        modelBuilder.Entity<Reg1390>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1390_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1390s).HasConstraintName("reg_1390_fk_esct");
        });

        modelBuilder.Entity<Reg1391>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1391_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1391s).HasConstraintName("reg_1391_fk_esct");
        });

        modelBuilder.Entity<Reg1400>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1400_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1400s).HasConstraintName("reg_1400_fk_esct");
        });

        modelBuilder.Entity<Reg1500>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1500_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1500s).HasConstraintName("reg_1500_fk_esct");
        });

        modelBuilder.Entity<Reg1510>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1510_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1510s).HasConstraintName("reg_1510_fk_esct");
        });

        modelBuilder.Entity<Reg1601>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1601_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1601s).HasConstraintName("reg_1601_fk_esct");
        });

        modelBuilder.Entity<Reg1700>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1700_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1700s).HasConstraintName("reg_1700_fk_esct");
        });

        modelBuilder.Entity<Reg1710>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1710_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1710s).HasConstraintName("reg_1710_fk_esct");
        });

        modelBuilder.Entity<Reg1800>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1800_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1800s).HasConstraintName("reg_1800_fk_esct");
        });

        modelBuilder.Entity<Reg1900>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1900_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1900s).HasConstraintName("reg_1900_fk_esct");
        });

        modelBuilder.Entity<Reg1910>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1910_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1910s).HasConstraintName("reg_1910_fk_esct");
        });

        modelBuilder.Entity<Reg1920>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1920_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1920s).HasConstraintName("reg_1920_fk_esct");
        });

        modelBuilder.Entity<Reg1921>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1921_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1921s).HasConstraintName("reg_1921_fk_esct");
        });

        modelBuilder.Entity<Reg1922>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1922_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1922s).HasConstraintName("reg_1922_fk_esct");
        });

        modelBuilder.Entity<Reg1923>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1923_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1923s).HasConstraintName("reg_1923_fk_esct");
        });

        modelBuilder.Entity<Reg1925>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1925_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1925s).HasConstraintName("reg_1925_fk_esct");
        });

        modelBuilder.Entity<Reg1926>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1926_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1926s).HasConstraintName("reg_1926_fk_esct");
        });

        modelBuilder.Entity<Reg1960>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1960_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1960s).HasConstraintName("reg_1960_fk_esct");
        });

        modelBuilder.Entity<Reg1970>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1970_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1970s).HasConstraintName("reg_1970_fk_esct");
        });

        modelBuilder.Entity<Reg1975>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1975_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1975s).HasConstraintName("reg_1975_fk_esct");
        });

        modelBuilder.Entity<Reg1980>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1980_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1980s).HasConstraintName("reg_1980_fk_esct");
        });

        modelBuilder.Entity<Reg1990>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_1990_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg1990s).HasConstraintName("reg_1990_fk_esct");
        });

        modelBuilder.Entity<Reg9001>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_9001_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg9001s).HasConstraintName("reg_9001_fk_esct");
        });

        modelBuilder.Entity<Reg9900>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_9900_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg9900s).HasConstraintName("reg_9900_fk_esct");
        });

        modelBuilder.Entity<Reg9990>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_9990_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg9990s).HasConstraintName("reg_9990_fk_esct");
        });

        modelBuilder.Entity<Reg9999>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_9999_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.Reg9999s).HasConstraintName("reg_9999_fk_esct");
        });

        modelBuilder.Entity<RegB001>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_b001_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegB001s).HasConstraintName("reg_b001_fk_esct");
        });

        modelBuilder.Entity<RegB020>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_b020_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegB020s).HasConstraintName("reg_b020_fk_esct");
        });

        modelBuilder.Entity<RegB025>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_b025_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegB025s).HasConstraintName("reg_b025_fk_esct");
        });

        modelBuilder.Entity<RegB030>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_b030_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegB030s).HasConstraintName("reg_b030_fk_esct");
        });

        modelBuilder.Entity<RegB035>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_b035_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegB035s).HasConstraintName("reg_b035_fk_esct");
        });

        modelBuilder.Entity<RegB350>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_b350_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegB350s).HasConstraintName("reg_b350_fk_esct");
        });

        modelBuilder.Entity<RegB420>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_b420_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegB420s).HasConstraintName("reg_b420_fk_esct");
        });

        modelBuilder.Entity<RegB440>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_b440_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegB440s).HasConstraintName("reg_b440_fk_esct");
        });

        modelBuilder.Entity<RegB460>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_b460_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegB460s).HasConstraintName("reg_b460_fk_esct");
        });

        modelBuilder.Entity<RegB470>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_b470_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegB470s).HasConstraintName("reg_b470_fk_esct");
        });

        modelBuilder.Entity<RegB500>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_b500_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegB500s).HasConstraintName("reg_b500_fk_esct");
        });

        modelBuilder.Entity<RegB510>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_b510_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegB510s).HasConstraintName("reg_b510_fk_esct");
        });

        modelBuilder.Entity<RegB990>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_b990_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegB990s).HasConstraintName("reg_b990_fk_esct");
        });

        modelBuilder.Entity<RegC001>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c001_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC001s).HasConstraintName("reg_c001_fk_esct");
        });

        modelBuilder.Entity<RegC100>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c100_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC100s).HasConstraintName("reg_c100_fk_esct");
        });

        modelBuilder.Entity<RegC101>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c101_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC101s).HasConstraintName("reg_c101_fk_esct");
        });

        modelBuilder.Entity<RegC105>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c105_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC105s).HasConstraintName("reg_c105_fk_esct");
        });

        modelBuilder.Entity<RegC110>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c110_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC110s).HasConstraintName("reg_c110_fk_esct");
        });

        modelBuilder.Entity<RegC111>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c111_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC111s).HasConstraintName("reg_c111_fk_esct");
        });

        modelBuilder.Entity<RegC112>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c112_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC112s).HasConstraintName("reg_c112_fk_esct");
        });

        modelBuilder.Entity<RegC113>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c113_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC113s).HasConstraintName("reg_c113_fk_esct");
        });

        modelBuilder.Entity<RegC114>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c114_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC114s).HasConstraintName("reg_c114_fk_esct");
        });

        modelBuilder.Entity<RegC115>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c115_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC115s).HasConstraintName("reg_c115_fk_esct");
        });

        modelBuilder.Entity<RegC116>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c116_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC116s).HasConstraintName("reg_c116_fk_esct");
        });

        modelBuilder.Entity<RegC120>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c120_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC120s).HasConstraintName("reg_c120_fk_esct");
        });

        modelBuilder.Entity<RegC130>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c130_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC130s).HasConstraintName("reg_c130_fk_esct");
        });

        modelBuilder.Entity<RegC140>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c140_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC140s).HasConstraintName("reg_c140_fk_esct");
        });

        modelBuilder.Entity<RegC141>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c141_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC141s).HasConstraintName("reg_c141_fk_esct");
        });

        modelBuilder.Entity<RegC160>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c160_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC160s).HasConstraintName("reg_c160_fk_esct");
        });

        modelBuilder.Entity<RegC165>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c165_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC165s).HasConstraintName("reg_c165_fk_esct");
        });

        modelBuilder.Entity<RegC170>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c170_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC170s).HasConstraintName("reg_c170_fk_esct");
        });

        modelBuilder.Entity<RegC171>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c171_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC171s).HasConstraintName("reg_c171_fk_esct");
        });

        modelBuilder.Entity<RegC172>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c172_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC172s).HasConstraintName("reg_c172_fk_esct");
        });

        modelBuilder.Entity<RegC173>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c173_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC173s).HasConstraintName("reg_c173_fk_esct");
        });

        modelBuilder.Entity<RegC174>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c174_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC174s).HasConstraintName("reg_c174_fk_esct");
        });

        modelBuilder.Entity<RegC175>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c175_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC175s).HasConstraintName("reg_c175_fk_esct");
        });

        modelBuilder.Entity<RegC176>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c176_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC176s).HasConstraintName("reg_c176_fk_esct");
        });

        modelBuilder.Entity<RegC177>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c177_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC177s).HasConstraintName("reg_c177_fk_esct");
        });

        modelBuilder.Entity<RegC178>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c178_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC178s).HasConstraintName("reg_c178_fk_esct");
        });

        modelBuilder.Entity<RegC179>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c179_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC179s).HasConstraintName("reg_c179_fk_esct");
        });

        modelBuilder.Entity<RegC180>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c180_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC180s).HasConstraintName("reg_c180_fk_esct");
        });

        modelBuilder.Entity<RegC181>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c181_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC181s).HasConstraintName("reg_c181_fk_esct");
        });

        modelBuilder.Entity<RegC185>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c185_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC185s).HasConstraintName("reg_c185_fk_esct");
        });

        modelBuilder.Entity<RegC186>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c186_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC186s).HasConstraintName("reg_c186_fk_esct");
        });

        modelBuilder.Entity<RegC190>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c190_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC190s).HasConstraintName("reg_c190_fk_esct");
        });

        modelBuilder.Entity<RegC191>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c191_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC191s).HasConstraintName("reg_c191_fk_esct");
        });

        modelBuilder.Entity<RegC195>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c195_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC195s).HasConstraintName("reg_c195_fk_esct");
        });

        modelBuilder.Entity<RegC197>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c197_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC197s).HasConstraintName("reg_c197_fk_esct");
        });

        modelBuilder.Entity<RegC300>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c300_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC300s).HasConstraintName("reg_c300_fk_esct");
        });

        modelBuilder.Entity<RegC310>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c310_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC310s).HasConstraintName("reg_c310_fk_esct");
        });

        modelBuilder.Entity<RegC320>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c320_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC320s).HasConstraintName("reg_c320_fk_esct");
        });

        modelBuilder.Entity<RegC321>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c321_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC321s).HasConstraintName("reg_c321_fk_esct");
        });

        modelBuilder.Entity<RegC330>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c330_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC330s).HasConstraintName("reg_c330_fk_esct");
        });

        modelBuilder.Entity<RegC350>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c350_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC350s).HasConstraintName("reg_c350_fk_esct");
        });

        modelBuilder.Entity<RegC370>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c370_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC370s).HasConstraintName("reg_c370_fk_esct");
        });

        modelBuilder.Entity<RegC380>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c380_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC380s).HasConstraintName("reg_c380_fk_esct");
        });

        modelBuilder.Entity<RegC390>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c390_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC390s).HasConstraintName("reg_c390_fk_esct");
        });

        modelBuilder.Entity<RegC400>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c400_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC400s).HasConstraintName("reg_c400_fk_esct");
        });

        modelBuilder.Entity<RegC405>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c405_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC405s).HasConstraintName("reg_c405_fk_esct");
        });

        modelBuilder.Entity<RegC410>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c410_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC410s).HasConstraintName("reg_c410_fk_esct");
        });

        modelBuilder.Entity<RegC420>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c420_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC420s).HasConstraintName("reg_c420_fk_esct");
        });

        modelBuilder.Entity<RegC425>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c425_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC425s).HasConstraintName("reg_c425_fk_esct");
        });

        modelBuilder.Entity<RegC430>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c430_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC430s).HasConstraintName("reg_c430_fk_esct");
        });

        modelBuilder.Entity<RegC460>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c460_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC460s).HasConstraintName("reg_c460_fk_esct");
        });

        modelBuilder.Entity<RegC465>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c465_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC465s).HasConstraintName("reg_c465_fk_esct");
        });

        modelBuilder.Entity<RegC470>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c470_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC470s).HasConstraintName("reg_c470_fk_esct");
        });

        modelBuilder.Entity<RegC480>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c480_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC480s).HasConstraintName("reg_c480_fk_esct");
        });

        modelBuilder.Entity<RegC490>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c490_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC490s).HasConstraintName("reg_c490_fk_esct");
        });

        modelBuilder.Entity<RegC500>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c500_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC500s).HasConstraintName("reg_c500_fk_esct");
        });

        modelBuilder.Entity<RegC510>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c510_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC510s).HasConstraintName("reg_c510_fk_esct");
        });

        modelBuilder.Entity<RegC590>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c590_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC590s).HasConstraintName("reg_c590_fk_esct");
        });

        modelBuilder.Entity<RegC591>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c591_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC591s).HasConstraintName("reg_c591_fk_esct");
        });

        modelBuilder.Entity<RegC595>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c595_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC595s).HasConstraintName("reg_c595_fk_esct");
        });

        modelBuilder.Entity<RegC597>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c597_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC597s).HasConstraintName("reg_c597_fk_esct");
        });

        modelBuilder.Entity<RegC600>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c600_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC600s).HasConstraintName("reg_c600_fk_esct");
        });

        modelBuilder.Entity<RegC601>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c601_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC601s).HasConstraintName("reg_c601_fk_esct");
        });

        modelBuilder.Entity<RegC610>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c610_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC610s).HasConstraintName("reg_c610_fk_esct");
        });

        modelBuilder.Entity<RegC690>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c690_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC690s).HasConstraintName("reg_c690_fk_esct");
        });

        modelBuilder.Entity<RegC695>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c695_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC695s).HasConstraintName("reg_c695_fk_esct");
        });

        modelBuilder.Entity<RegC790>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c790_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC790s).HasConstraintName("reg_c790_fk_esct");
        });

        modelBuilder.Entity<RegC791>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c791_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC791s).HasConstraintName("reg_c791_fk_esct");
        });

        modelBuilder.Entity<RegC800>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c800_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC800s).HasConstraintName("reg_c800_fk_esct");
        });

        modelBuilder.Entity<RegC810>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c810_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC810s).HasConstraintName("reg_c810_fk_esct");
        });

        modelBuilder.Entity<RegC815>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c815_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC815s).HasConstraintName("reg_c815_fk_esct");
        });

        modelBuilder.Entity<RegC850>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c850_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC850s).HasConstraintName("reg_c850_fk_esct");
        });

        modelBuilder.Entity<RegC855>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c855_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC855s).HasConstraintName("reg_c855_fk_esct");
        });

        modelBuilder.Entity<RegC857>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c857_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC857s).HasConstraintName("reg_c857_fk_esct");
        });

        modelBuilder.Entity<RegC860>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c860_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC860s).HasConstraintName("reg_c860_fk_esct");
        });

        modelBuilder.Entity<RegC870>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c870_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC870s).HasConstraintName("reg_c870_fk_esct");
        });

        modelBuilder.Entity<RegC880>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c880_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC880s).HasConstraintName("reg_c880_fk_esct");
        });

        modelBuilder.Entity<RegC890>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c890_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC890s).HasConstraintName("reg_c890_fk_esct");
        });

        modelBuilder.Entity<RegC895>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c895_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC895s).HasConstraintName("reg_c895_fk_esct");
        });

        modelBuilder.Entity<RegC897>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_c897_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegC897s).HasConstraintName("reg_c897_fk_esct");
        });

        modelBuilder.Entity<RegD001>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_d001_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegD001s).HasConstraintName("reg_d001_fk_esct");
        });

        modelBuilder.Entity<RegD100>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.IdEsct }).HasName("reg_d100_pkey");

            entity.HasOne(d => d.IdEsctNavigation).WithMany(p => p.RegD100s).HasConstraintName("reg_d100_fk_esct");
        });

        modelBuilder.Entity<TabelaUf>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tabela_uf_pkey");

            entity.Property(e => e.Codigo).ValueGeneratedNever();
            entity.Property(e => e.Sigla).IsFixedLength();
        });

        modelBuilder.Entity<Tabelaexternareferenciadum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tabelaexternareferenciada_pkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
