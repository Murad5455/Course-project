using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorseEntity.Concrete
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
       
        public string? TeacherName { get; set; }
        
        public string? TeacherLastname { get; set; }
        
        public int TeacherAge { get; set; }
       
        public string? Position { get; set; }

        public bool Status { get; set; }

        public List<GroupAbout> Group { get; set; }
    }
}
