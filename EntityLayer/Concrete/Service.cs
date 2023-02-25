using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Service
    {
        [Key]
        public int serviceID { get; set; }
        public string title { get; set; }
        public string imageurl { get; set; }

    }
}
