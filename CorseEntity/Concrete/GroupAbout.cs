using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorseEntity.Concrete
{
    public class GroupAbout
    {
        [Key]
        public int GroupId { get; set; }

        public string GroupName { get; set; }
       
        public DateTime CreateTime { get; set; }

        public bool Status { get; set; }

        public int LanguageAboutId { get; set; }

        public LanguageAbout LanguageAbout { get; set; }

        public  List<Student> Student { get; set; }

        public int TeacherId { get; set; }

        public Teacher Teacher { get; set; }

        public List<Schedule> Schedule { get; set; }

        // public List<ClassSchedule> ClassSchedule { get; set; }

    }
}
