using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjecttManager.Models
{
    public class ProjectsDbContext : DbContext
    {
        public ProjectsDbContext(DbContextOptions<ProjectsDbContext> options):base(options)
        {

        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Tache> Taches { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Timesheet> Timesheets { get; set; }
        public DbSet<Affectation> Affectations { get; set; }

    }
}
