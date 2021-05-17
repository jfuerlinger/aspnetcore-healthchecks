using DockerTutorial.WebApi.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerTutorial.WebApi
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }

        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Note> Notes { get; set; }
    }
}
