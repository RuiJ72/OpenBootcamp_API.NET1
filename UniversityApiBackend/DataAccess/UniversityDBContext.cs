using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.Models;
using UniversityApiBackend.Models.DataModels;
using Chapters = UniversityApiBackend.Models.DataModels.Chapters;

namespace UniversityApiBackend.DataAccess
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options)
        {

        }

        // TODO tablas de la base datos
        public DbSet<User>? Users { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Chapter>? Chapters { get; set; }
        public DbSet<Categoria>? Categorias { get; set; } 
        public DbSet<Student>? Students { get; set; }
       
    }
}
