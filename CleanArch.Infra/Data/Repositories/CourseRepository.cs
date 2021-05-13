using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDBContext _context;

        public CourseRepository(UniversityDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Course> GetCourses()
        {
            IQueryable<Course> query = _context.Courses;
            return query.ToList();
        }

        public async Task<IEnumerable<Course>> GetCoursesAsync()
        {
            IQueryable<Course> query = _context.Courses;
            return await query.ToListAsync();
        }

    }
}
