using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LosPollosHermanos.Models
{
    public class Load
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public decimal Quantity { get; set; }
        public decimal Weight { get; set; }
    }
}