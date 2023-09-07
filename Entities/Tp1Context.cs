using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TP_1.Entities;

public partial class Tp1Context : DbContext
{
    public Tp1Context()
    {
    }

    public Tp1Context(DbContextOptions<Tp1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Auteur> Auteurs { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Commande> Commandes { get; set; }

    public virtual DbSet<Partition> Partitions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=127.0.0.1;port=3306;user=root;database=tp-1", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.28-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Auteur>(entity =>
        {
            entity.HasKey(e => e.Numaut).HasName("PRIMARY");

            entity.ToTable("auteur");

            entity.Property(e => e.Numaut)
                .HasColumnType("int(11)")
                .HasColumnName("NUMAUT");
            entity.Property(e => e.Nomaut)
                .HasMaxLength(128)
                .HasColumnName("NOMAUT");
            entity.Property(e => e.Prenomaut)
                .HasMaxLength(128)
                .HasColumnName("PRENOMAUT");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Numcli).HasName("PRIMARY");

            entity.ToTable("client");

            entity.Property(e => e.Numcli)
                .HasColumnType("int(11)")
                .HasColumnName("NUMCLI");
            entity.Property(e => e.Adrcli)
                .HasMaxLength(128)
                .HasColumnName("ADRCLI");
            entity.Property(e => e.Nomcli)
                .HasMaxLength(128)
                .HasColumnName("NOMCLI");
            entity.Property(e => e.Prenomcli)
                .HasMaxLength(128)
                .HasColumnName("PRENOMCLI");
        });

        modelBuilder.Entity<Commande>(entity =>
        {
            entity.HasKey(e => e.Numcde).HasName("PRIMARY");

            entity.ToTable("commande");

            entity.HasIndex(e => e.Numcli, "I_FK_COMMANDE_ADHERENT");

            entity.Property(e => e.Numcde)
                .HasColumnType("int(11)")
                .HasColumnName("NUMCDE");
            entity.Property(e => e.Datecde).HasColumnName("DATECDE");
            entity.Property(e => e.Montantcde)
                .HasColumnType("int(11)")
                .HasColumnName("MONTANTCDE");
            entity.Property(e => e.Numcli)
                .HasColumnType("int(11)")
                .HasColumnName("NUMCLI");

            entity.HasOne(d => d.NumcliNavigation).WithMany(p => p.Commandes)
                .HasForeignKey(d => d.Numcli)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_COMMANDE_ADHERENT");

            entity.HasMany(d => d.Numparts).WithMany(p => p.Numcdes)
                .UsingEntity<Dictionary<string, object>>(
                    "Contenir",
                    r => r.HasOne<Partition>().WithMany()
                        .HasForeignKey("Numpart")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("contenir_ibfk_2"),
                    l => l.HasOne<Commande>().WithMany()
                        .HasForeignKey("Numcde")
                        .HasConstraintName("contenir_ibfk_1"),
                    j =>
                    {
                        j.HasKey("Numcde", "Numpart")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("contenir");
                        j.HasIndex(new[] { "Numcde" }, "I_FK_CONTENIR_COMMANDE");
                        j.HasIndex(new[] { "Numpart" }, "NUMPART");
                        j.IndexerProperty<int>("Numcde")
                            .HasColumnType("int(11)")
                            .HasColumnName("NUMCDE");
                        j.IndexerProperty<int>("Numpart")
                            .HasColumnType("int(11)")
                            .HasColumnName("NUMPART");
                    });
        });

        modelBuilder.Entity<Partition>(entity =>
        {
            entity.HasKey(e => e.Numpart).HasName("PRIMARY");

            entity.ToTable("partitions");

            entity.Property(e => e.Numpart)
                .HasColumnType("int(11)")
                .HasColumnName("NUMPART");
            entity.Property(e => e.Libpart)
                .HasMaxLength(128)
                .HasColumnName("LIBPART");
            entity.Property(e => e.Prixpart)
                .HasColumnType("int(11)")
                .HasColumnName("PRIXPART");

            entity.HasMany(d => d.Numauts).WithMany(p => p.Numparts)
                .UsingEntity<Dictionary<string, object>>(
                    "Ecrire",
                    r => r.HasOne<Auteur>().WithMany()
                        .HasForeignKey("Numaut")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("ecrire_ibfk_2"),
                    l => l.HasOne<Partition>().WithMany()
                        .HasForeignKey("Numpart")
                        .HasConstraintName("ecrire_ibfk_1"),
                    j =>
                    {
                        j.HasKey("Numpart", "Numaut")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("ecrire");
                        j.HasIndex(new[] { "Numaut" }, "I_FK_ECRIRE_AUTEUR");
                        j.HasIndex(new[] { "Numpart" }, "I_FK_ECRIRE_PARTITIONS");
                        j.IndexerProperty<int>("Numpart")
                            .HasColumnType("int(11)")
                            .HasColumnName("NUMPART");
                        j.IndexerProperty<int>("Numaut")
                            .HasColumnType("int(11)")
                            .HasColumnName("NUMAUT");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
