using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Feature
    {
        [Key]
        public int featureID { get; set; }
        public string header { get; set; }
        public string name { get; set; }
        public string title { get; set; }
    }
}
