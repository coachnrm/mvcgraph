using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Models
{
    public class Patient
    {
        [Key]
        public int Id {get; set;}

        public DateTime CreatedAt {get; set;} = DateTime.Now;

        public string? Qn {get; set;}
    }
}