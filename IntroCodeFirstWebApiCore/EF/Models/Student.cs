using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntroCodeFirstWebApiCore.EF.Models
{
    public class Student
    {

        [Key]
        public int StudentId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }


        [Range(10,100)]
        public string Age { get; set; }


        public DateTime DateOfBirth { get; set; }

        [ForeignKey("Dept")]
        public int DeptId { get; set; }

        public virtual Department Dept { get; set; }



        //public int Id{  get; set; }

        //[Required]
        //[MaxLength(100)]
        //[Column(TypeName = "VARCHAR")]
        //public string Name { get; set; }

        //[Required]
        //[MaxLength(100)]
        //[Column(TypeName = "VARCHAR")]
        //public string Email { get; set; }

        //[Required]
        //[MaxLength(100)]
        //[Column(TypeName = "VARCHAR")]
        //public string Password { get; set; }
    }
}
