using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LosPollosHermanos.Models
{
    public class Shipment
    {
        public int Id { get; set; }
        public DateTime DepartTime { get; set; }
        public string Location { get; set; }
        public int LoadId { get; set; }
        public Load Load { get; set; }
    }
}