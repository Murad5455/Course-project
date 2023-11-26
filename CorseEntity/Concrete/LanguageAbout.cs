using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorseEntity.Concrete
{
    public class LanguageAbout
    {
        [Key]
        public int LanguageAboutId { get; set; }
        
        public string? LanguageName { get; set; }
      
        public string? Description { get; set; }

        public DateTime CreateLanguageTime { get; set; }

        public bool Status { get; set; }

        public List<GroupAbout>Group { get; set; }

    }
}
