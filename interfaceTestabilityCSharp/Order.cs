using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceTestabilityCSharp
{
    public class Order
    {
        public float TotalPrice { get; set; }
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }
        public Shipment Shipment { get; set; }
        public bool IsShipped
        {
            get { return Shipment != null; }
        }


    }
}
