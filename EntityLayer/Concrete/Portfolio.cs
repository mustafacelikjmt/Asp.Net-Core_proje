using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Portfolio
    {
        [Key]
        public int portfolioID { get; set; }
        public string name { get; set; }
        public string imageurl { get; set; }
    }
}
