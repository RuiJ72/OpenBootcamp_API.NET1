using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{   

    public enum Level
    {
        Basico,
        Medio,
        Avanzado,
        Experto
    }
    public class Course : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(200)]
        public string ShortDescription { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
        public Level Level { get; set; } = Level.Basico;

        [Required]
        public ICollection<Categoria> categorias { get; set; } = new List<Categoria>();
        [Required]
        public Chapter Chapter { get; set; } = new Chapter();

        [Required]
        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
