using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RainbowSchool.Model;

namespace RainbowSchool.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext (DbContextOptions<SchoolDbContext> options)
            : base(options)
        {
        }

        public DbSet<RainbowSchool.Model.Students> Students { get; set; } = default!;

        public DbSet<RainbowSchool.Model.Subjects>? Subjects { get; set; }

        public DbSet<RainbowSchool.Model.Marks>? Marks { get; set; }
    }
}
