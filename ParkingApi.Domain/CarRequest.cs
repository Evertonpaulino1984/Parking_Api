using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApi.Domain
{
    public class CarRequest
    {
        public string Model { get; set; }
        public int YearFabrication { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public bool Brazilian { get; set; }
    }
}
