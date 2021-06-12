
using Microsoft.EntityFrameworkCore;
using AttendanceMgmtFYP.Models;

namespace AttendanceMgmtFYP.Data
{
    public partial class Context : DbContext
    { public Context()
    {
    }

    public Context(DbContextOptions<Context> options)
        : base(options)
    {
    }

        public virtual DbSet<DaysOfWeek> DaysOfWeeks { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TimeTable> TimeTables { get; set; }
        public virtual DbSet<TimeTableDatum> TimeTableData { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<DaysOfWeek>(entity =>
            {
                entity.HasKey(e => e.DayId);

                entity.ToTable("DaysOfWeek");

                entity.Property(e => e.DayName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasKey(e=>e.TeacherId);

                entity.Property(e => e.Cnic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNIC");

                entity.Property(e => e.DateofBirth).HasColumnType("datetime");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrignalFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TimeTable>(entity =>
            {
                entity.ToTable("TimeTable");

                entity.Property(e => e._01300300)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("0130-0300");

                entity.Property(e => e._03000430)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("0300-0430");

                entity.Property(e => e._06000800)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("0600-0800");

                entity.Property(e => e._08001000)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("0800-1000");

                entity.Property(e => e._08301000)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("0830-1000");

                entity.Property(e => e._10001130)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("1000-1130");

                entity.Property(e => e._11300100)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("1130-0100");
            });

            modelBuilder.Entity<TimeTableDatum>(entity =>
            {
                entity.HasKey(e => e.TimeTableId);

                entity.Property(e => e.CreatedDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeIn01300300)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeIn03000430)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeIn06000800)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeIn08001000)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeIn08301000)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeIn10001130)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeIn11300100)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeOut01300300)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeOut03000430)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeOut06000800)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeOut08001000)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeOut08301000)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeOut10001130)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeOut11300100)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._01300300)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("0130-0300");

                entity.Property(e => e._03000430)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("0300-0430");

                entity.Property(e => e._06000800)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("0600-0800");

                entity.Property(e => e._08001000)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("0800-1000");

                entity.Property(e => e._08301000)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("0830-1000");

                entity.Property(e => e._10001130)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("10001130");

                entity.Property(e => e._11300100)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("1130-0100");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Username).HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}