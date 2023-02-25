using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Skill
    {
        [Key]
        public int skillID { get; set; }
        public string title { get; set; }
        public string value { get; set; }
        
    }
}
