using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Models
{
    public class NurseRequest 
    {
        [Key]
        public int Id {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public string? PatientType {get; set;}
        public string? PortalType {get; set;}
        public string? Remark {get; set;}
        public string? StartPoint {get; set;}
        public string? EndPoint {get; set;}
        public ICollection<Patient> Patients {get; set;}
    }
}