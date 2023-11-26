using CorseEntity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorseEntity.Concrete
{
    public class Evaluation
    {
        [Key]
        public int EvaluationId { get; set; }
       
        public int Price { get; set; }

        public bool Continuity { get; set; }

        public DateTime PriceGiveDate { get; set; } 

        public bool Status { get; set; }

        public int StudentID { get; set; }  

        public Student Student { get; set; }

    }
}


