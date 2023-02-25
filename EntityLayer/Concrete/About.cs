using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int aboutID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string age { get; set; }
        public string mail { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string imageurl { get; set; }
    }
}
