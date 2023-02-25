using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Testimonial
    {
        [Key]
        public int testimonialID { get; set; }
        public string clientname { get; set; }
        public string company { get; set; }
        public string comment { get; set; }
        public string imageurl { get; set; }
    }
}
