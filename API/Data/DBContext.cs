
using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Data
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
            Database.SetCommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds);
        }

        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<AreaLang> AreaLang { get; set; }
        public virtual DbSet<BuildLang> BuildLang { get; set; }
        public virtual DbSet<Building> Building { get; set; }
        public virtual DbSet<CatLang> CatLang { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CommentArchive> CommentArchive { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CountAll> CountAll { get; set; }
        public virtual DbSet<CountArea> CountArea { get; set; }
        public virtual DbSet<CountBuilding> CountBuilding { get; set; }
        public virtual DbSet<CountDepartment> CountDepartment { get; set; }
        public virtual DbSet<CountPart> CountPart { get; set; }
        public virtual DbSet<DatePickerManager> DatePickerManager { get; set; }
        public virtual DbSet<DefaultSetting> DefaultSetting { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<DetpLang> DetpLang { get; set; }
        public virtual DbSet<EmailContent> EmailContent { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<ErrorLog> ErrorLog { get; set; }
        public virtual DbSet<GroupBase> GroupBase { get; set; }
        public virtual DbSet<GroupLang> GroupLang { get; set; }
        public virtual DbSet<HistoryEmp> HistoryEmp { get; set; }
        public virtual DbSet<Holiday> Holiday { get; set; }
        public virtual DbSet<LeaveData> LeaveData { get; set; }
        public virtual DbSet<LeaveLog> LeaveLog { get; set; }
        public virtual DbSet<LoginDetect> LoginDetect { get; set; }
        public virtual DbSet<Part> Part { get; set; }
        public virtual DbSet<PartLang> PartLang { get; set; }
        public virtual DbSet<PosLang> PosLang { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<ReportData> ReportData { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Roles_User> Roles_User { get; set; }
        public virtual DbSet<SetApproveGroupBase> SetApproveGroupBase { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<tempdata> tempdata { get; set; }
        public virtual DbSet<tempuser> tempuser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatLang>(entity =>
            {
                entity.HasKey(e => e.CateLangID);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CateID);
            });

            modelBuilder.Entity<CountAll>(entity =>
            {
                entity.HasKey(e => e.Count_ID);
            });

            modelBuilder.Entity<CountArea>(entity =>
            {
                entity.HasKey(e => e.Count_ID);
            });

            modelBuilder.Entity<CountBuilding>(entity =>
            {
                entity.HasKey(e => e.Count_ID);
            });

            modelBuilder.Entity<CountDepartment>(entity =>
            {
                entity.HasKey(e => e.Count_ID);
            });

            modelBuilder.Entity<CountPart>(entity =>
            {
                entity.HasKey(e => e.Count_ID);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DeptID);
            });

            modelBuilder.Entity<DetpLang>(entity =>
            {
                entity.HasKey(e => e.DeptLangID);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpID);
            });

            modelBuilder.Entity<GroupBase>(entity =>
            {
                entity.HasKey(e => e.GBID);
            });

            modelBuilder.Entity<HistoryEmp>(entity =>
            {
                entity.HasKey(e => e.HisrotyID);
            });

            modelBuilder.Entity<LeaveData>(entity =>
            {
                entity.HasKey(e => e.LeaveID);
            });

            modelBuilder.Entity<LeaveLog>(entity =>
            {
                entity.Property(e => e.EmpNumber).IsUnicode(false);

                entity.Property(e => e.LoggedByIP).IsUnicode(false);
            });

            modelBuilder.Entity<LoginDetect>(entity =>
            {
                entity.Property(e => e.LoggedByIP).IsUnicode(false);

                entity.Property(e => e.UserName).IsUnicode(false);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RoleID);
            });

            modelBuilder.Entity<Roles_User>(entity =>
            {
                entity.HasKey(e => e.RolesUserID);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Roles_User)
                    .HasForeignKey(d => d.RoleID);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Roles_User)
                    .HasForeignKey(d => d.UserID);
            });

            modelBuilder.Entity<SetApproveGroupBase>(entity =>
            {
                entity.HasKey(e => e.SAGBID);

                entity.HasOne(d => d.GB)
                    .WithMany(p => p.SetApproveGroupBase)
                    .HasForeignKey(d => d.GBID);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SetApproveGroupBase)
                    .HasForeignKey(d => d.UserID);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserID);

                entity.Property(e => e.HashImage);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}