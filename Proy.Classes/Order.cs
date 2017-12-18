using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy.Classes
{
    public class Order : BaseObject
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        //public int Employee{ get; set; }
        [ForeignKey("Employee")]
        public int Employee_ID { get; set; }
        public Employee Employee { get; set; }


    }
}
