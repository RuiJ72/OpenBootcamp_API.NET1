using System.ComponentModel.DataAnnotations;


namespace UniversityApiBackend.Models.DataModels
{
    public class Chapters : BaseEntity
    {
        [Required]
        public string List = string.Empty;
    }
}
