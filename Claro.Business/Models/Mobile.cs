using System;
using System.Collections.Generic;
using System.Text;

namespace Claro.Business.Models
{
    public class Mobile : Entity
    {
        public int Price { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Date { get; set; }
        public string Photo { get; set; }
    }
}
