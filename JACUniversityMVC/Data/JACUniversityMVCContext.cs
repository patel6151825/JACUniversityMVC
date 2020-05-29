using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JACUniversityMVC.Models;

namespace JACUniversityMVC.Models
{
    public class JACUniversityMVCContext : DbContext
    {
        public JACUniversityMVCContext (DbContextOptions<JACUniversityMVCContext> options)
            : base(options)
        {
        }

        public DbSet<JACUniversityMVC.Models.Student> Student { get; set; }

        public DbSet<JACUniversityMVC.Models.Course> Course { get; set; }

        public DbSet<JACUniversityMVC.Models.Enrollment> Enrollment { get; set; }
    }
}
