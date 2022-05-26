using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    [Serializable]
    public class Order_Header
    {
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
