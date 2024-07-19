using _18_CourseAppEF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_CourseAppEF.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<ExamResult> ExamResults { get; set; }
        public DbSet<Exam> Exams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CourseDBV5;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //StudentID ve ExamID alanları Composite Key olarak set edildi. (primary key)
            modelBuilder.Entity<ExamResult>()
                .HasKey(e => new { e.StudentID, e.ExamID });

            modelBuilder.Entity<ExamResult>()
                .Ignore(e => e.ID);
           
        }
    }
}
