using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorseEntity.Concrete
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        public string? StudentName { get; set; }

        public string? StudentSureName { get; set; }

        public int StudentAge { get; set; }

        public bool Status { get; set; }

        public DateTime CreateStudentTime { get; set; }

        public int GroupId { get; set; }

        public GroupAbout Group { get; set; }

        public List<Evaluation> Evaluation { get; set; }  

        public List<Exam> Exam { get; set; }
    }
}
