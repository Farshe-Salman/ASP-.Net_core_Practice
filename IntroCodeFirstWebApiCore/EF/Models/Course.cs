using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntroCodeFirstWebApiCore.EF.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public int Credits { get; set; }

        [ForeignKey("DM")]
        public int DeptId { get; set; }
        public virtual Department DM{ get; set; }


    }
}
