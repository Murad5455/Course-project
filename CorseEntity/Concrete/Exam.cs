using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorseEntity.Concrete
{
    public class Exam
    {
        [Key]
        public int ExamId { get; set; }

        public string ExamTopic { get; set; }
        
        public int ExamGrade { get; set; }

        public DateTime ExamTime { get; set; }

        public bool Status { get; set; }

        public Student Student { get; set; }

        public int StudentID { get; set; }
    }
}
