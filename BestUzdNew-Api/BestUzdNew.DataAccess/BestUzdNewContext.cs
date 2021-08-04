using BestUzdNew.DataAccess.Extensions;
using BestUzdNew.Domain.Contracts;
using BestUzdNew.Domain.Entities;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BestUzdNew.DataAccess
{
    public partial class BestUzdNewContext : DbContext
    {
        public BestUzdNewContext()
        {
        }

        public BestUzdNewContext(DbContextOptions<BestUzdNewContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DiscountType> DiscountTypes { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceDiscount> ServiceDiscounts { get; set; }
        public virtual DbSet<ServiceGroup> ServiceGroups { get; set; }
        public virtual DbSet<ServiceGroupDiscount> ServiceGroupDiscounts { get; set; }
        public virtual DbSet<ServiceGroupToService> ServiceGroupToServices { get; set; }
        public virtual DbSet<ServiceSetDiscount> ServiceSetDiscounts { get; set; }
        public virtual DbSet<ServiceSetDiscountToService> ServiceSetDiscountToServices { get; set; }
        public virtual DbSet<Translation> Translations { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserInformation> UserInformations { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=BestUzdNew;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<DiscountType>(entity =>
            {
                entity.ToTable("DiscountType");

                entity.Property(e => e.DescriptionAlias).IsRequired();

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.NameAlias)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("Language");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FamilyName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Order_ServiceFK");
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.ToTable("Schedule");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EndTime).HasColumnType("date");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.StartTime).HasColumnType("date");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("Service");

                entity.Property(e => e.DescriptionAlias).IsRequired();

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.NameAlias)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ServiceDiscount>(entity =>
            {
                entity.ToTable("ServiceDiscount");

                entity.Property(e => e.DescriptionAlias).IsRequired();

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.NameAlias)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.DiscountType)
                    .WithMany(p => p.ServiceDiscounts)
                    .HasForeignKey(d => d.DiscountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ServiceDiscount_DiscountTypeFK");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceDiscounts)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("ServiceDiscount_ServiceFK");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ServiceDiscounts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("ServiceDiscount_UserFK");
            });

            modelBuilder.Entity<ServiceGroup>(entity =>
            {
                entity.ToTable("ServiceGroup");

                entity.Property(e => e.DescriptionAlias).IsRequired();

                entity.Property(e => e.NameAlias)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ServiceGroupDiscount>(entity =>
            {
                entity.ToTable("ServiceGroupDiscount");

                entity.Property(e => e.DescriptionAlias).IsRequired();

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.NameAlias)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.DiscountType)
                    .WithMany(p => p.ServiceGroupDiscounts)
                    .HasForeignKey(d => d.DiscountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ServiceGroupDiscount_DiscountTypeFK");

                entity.HasOne(d => d.ServiceGroup)
                    .WithMany(p => p.ServiceGroupDiscounts)
                    .HasForeignKey(d => d.ServiceGroupId)
                    .HasConstraintName("ServiceGroupDiscount_ServiceGroupFK");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ServiceGroupDiscounts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("ServiceGroupDiscount_UserFK");
            });

            modelBuilder.Entity<ServiceGroupToService>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ServiceGroupToService");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.ServiceGroup)
                    .WithMany()
                    .HasForeignKey(d => d.ServiceGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ServiceGroupToService_ServiceGroupFK");

                entity.HasOne(d => d.Service)
                    .WithMany()
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ServiceGroupToService_ServiceFK");
            });

            modelBuilder.Entity<ServiceSetDiscount>(entity =>
            {
                entity.ToTable("ServiceSetDiscount");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.DiscountType)
                    .WithMany(p => p.ServiceSetDiscounts)
                    .HasForeignKey(d => d.DiscountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ServiceSetDiscount_DiscountTypeFK");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ServiceSetDiscounts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("ServiceSetDiscount_UserFK");
            });

            modelBuilder.Entity<ServiceSetDiscountToService>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ServiceSetDiscountToService");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Service)
                    .WithMany()
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ServiceSetDiscountToService_ServiceFK");

                entity.HasOne(d => d.ServiceSetDiscount)
                    .WithMany()
                    .HasForeignKey(d => d.ServiceSetDiscountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ServiceSetDiscountToService_ServiceSetDiscountFK");
            });

            modelBuilder.Entity<Translation>(entity =>
            {
                entity.ToTable("Translation");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Translation1)
                    .IsRequired()
                    .HasColumnName("Translation");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Translations)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Translation_LanguageFK");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.UserInformation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserInformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("User_UserInformationFK");

                entity.HasOne(d => d.UserRole)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_UserRole");
            });

            modelBuilder.Entity<UserInformation>(entity =>
            {
                entity.ToTable("UserInformation");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.FamilyName).HasMaxLength(200);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("UserRole");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.NameAlias)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);

            // https://www.thereformedprogrammer.net/ef-core-in-depth-soft-deleting-data-with-global-query-filters/
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                //other automated configurations left out
                if (typeof(ISoftDelete).IsAssignableFrom(entityType.ClrType))
                {
                    entityType.AddSoftDeleteQueryFilter();
                }
            }
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
