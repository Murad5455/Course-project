using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorseEntity.Concrete
{
    public class Schedule
    {
            [Key]
            public int ClassScheduleId { get; set; }

            public string? Monday { get; set; }

            public string? Tuesday { get; set; }

            public string? Wednesday { get; set; }

            public string? Thursday { get; set; }

            public string? Friday { get; set; }

            public string? Saturday { get; set; }

            public string? Sunday { get; set; }

            public bool Status { get; set; }

            public DateTime CreateTime { get; set; }

            public int GroupId { get; set; }
           
            public GroupAbout Group { get; set; }


    }
}
