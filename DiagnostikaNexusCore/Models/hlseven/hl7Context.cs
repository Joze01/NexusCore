using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DiagnostikaNexusCore.Models.hlseven
{
    public partial class hl7Context : DbContext
    {
        public hl7Context()
        {
        }

        public hl7Context(DbContextOptions<hl7Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<EstadosTransacciones> EstadosTransacciones { get; set; }
        public virtual DbSet<Sessions> Sessions { get; set; }
        public virtual DbSet<Transacciones> Transacciones { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=hl7;user id=developer; password=270494");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<EstadosTransacciones>(entity =>
            {
                entity.HasKey(e => e.Idestado);

                entity.ToTable("estadosTransacciones");

                entity.Property(e => e.Idestado).HasColumnName("idestado");

                entity.Property(e => e.Nombreestado)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sessions>(entity =>
            {
                entity.ToTable("sessions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Transacciones>(entity =>
            {
                entity.HasKey(e => e.Indice);

                entity.ToTable("transacciones");

                entity.Property(e => e.Completas)
                    .HasColumnName("completas")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Orc).HasColumnName("orc");

                entity.Property(e => e.Ox)
                    .HasColumnName("ox")
                    .HasMaxLength(50);

                entity.Property(e => e.Peticion)
                    .IsRequired()
                    .HasColumnName("peticion")
                    .IsUnicode(false);

                entity.Property(e => e.Pruebas)
                    .HasColumnName("pruebas")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Respuesta)
                    .HasColumnName("respuesta")
                    .IsUnicode(false);

                entity.Property(e => e.Siapsid)
                    .HasColumnName("siapsid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.Transacciones)
                    .HasForeignKey(d => d.Estado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_transacciones_estadosTransacciones");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
