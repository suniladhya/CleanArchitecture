using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.SeedData
{
    public static class ModelBuilderExtensions
    {
        public static void SeedCourse(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
            new Course
            {
                Id = 1,
                Name = "Social Science",
                Description = "Study about Social Science",
                ImageUrl = "/images/art-ball-shaped-circle-414860.jpg"
            },
            new Course
            {
                Id = 2,
                Name = "Moral Science",
                Description = "Study about Moral behavior in Society",
                ImageUrl = "/images/blue-bubble-crystal-clear-132477.jpg"
            },
            new Course
            {
                Id = 3,
                Name = "Behavior Science",
                Description = "Study about behavior in Society",
                ImageUrl = "/images/book-education-graphing-paper-167682.jpg"
            });
        }
    }
}
