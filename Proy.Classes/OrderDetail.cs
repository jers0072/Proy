using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy.Classes
{
    public class OrderDetail : BaseObject
    {
        public int ID { get; set; }
        public Order Order { set; get; }
        public int MaterialNumber { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        
    }
}
