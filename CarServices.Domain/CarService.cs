using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServices.Domain
{
    public class CarService
    {
        public Guid Id { get; set; }
        public Guid ServiceId { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Year_car { get; set; }
        public int Cost_car { get; set; }
        public bool Status_car { get; set; }
    }
}
