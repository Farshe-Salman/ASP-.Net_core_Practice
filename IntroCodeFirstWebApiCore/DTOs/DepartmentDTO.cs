using System.ComponentModel.DataAnnotations;

namespace IntroCodeFirstWebApiCore.DTOs
{
    public class DepartmentDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(250)]
        public string Description { get; set; }
    }
}
