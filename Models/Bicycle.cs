using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeRent_Back_End.Models
{
    public class Bicycle
    {
        public int Id { get; private set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
    }
}
