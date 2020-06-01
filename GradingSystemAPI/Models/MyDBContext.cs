using System;
using Microsoft.EntityFrameworkCore;

namespace GradingSystemAPI.Models
{
    public class MyDBContext : DbContext
    {
        public DbSet<Student> Student { get; set; }
        public DbSet<Faculty> faculty { get; set; }
        public DbSet<Grading_schema> grading_Schema { get; set; }
        public DbSet<Course> course { get; set; }
        public DbSet<CourseList> courseList { get; set; }

        public MyDBContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=208.118.63.142; Database=DB_A61801_test;User=DB_A61801_test_admin; Password=aliakber123;");
        }
    }
}
