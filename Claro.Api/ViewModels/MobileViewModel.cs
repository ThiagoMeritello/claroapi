using System;
using System.ComponentModel.DataAnnotations;

namespace Claro.Api.ViewModels
{
    public class MobileViewModel
    {
        [Key]
        public Guid? Code { get; set; }
        public int Price { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Date { get; set; }
        public string Photo { get; set; }
    }
}
