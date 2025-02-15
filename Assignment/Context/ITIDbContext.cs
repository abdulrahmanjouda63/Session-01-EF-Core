using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Assignment.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Context
{
    public class ITIDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasKey(d => d.ID);
            modelBuilder.Entity<Topic>()
                .HasKey(t => t.ID);
            modelBuilder.Entity<Course>()
                .HasKey(c => c.ID);
            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.Stud_ID, sc.Course_ID });
            modelBuilder.Entity<Course_Inst>()
                .HasKey(ci => new { ci.Inst_ID, ci.Course_ID });
        }
    }
}
