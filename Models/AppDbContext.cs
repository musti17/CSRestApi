using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRestAPI.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
            public DbSet<Student> Students { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
            base.OnModelCreating(modelBuilder);

            //send Student table
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 1,
                    FirstName = "Mustafa",
                    LastName = "Zahid",
                    Email = "mustafazahid167@hotmail.com",
                    Gender = Gender.Male,
                    DepartmentId =1,
                    PhotoPath = "images/Mustafa.png"
                });
            modelBuilder.Entity<Student>().HasData(
           new Student
           {
               StudentId = 2,
               FirstName = "Mohammad",
               LastName = "Zahid",
               Email = "mohammadzahid167@hotmail.com",
               Gender = Gender.Male,
               DepartmentId = 2,
               PhotoPath = "images/Mustafa.png"
           });
            modelBuilder.Entity<Student>().HasData(
           new Student
           {
               StudentId = 3,
               FirstName = "Sara",
               LastName = "Riaz",
               Email = "sara167@hotmail.com",
               Gender = Gender.Female,
               DepartmentId = 3,
               PhotoPath = "images/sara.png"
           });
        }

    }
}
