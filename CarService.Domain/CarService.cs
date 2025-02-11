using System;

namespace CarService.Domain
{
    public class CarService
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Year_car {  get; set; }
        public int Cost_car { get; set; }
        public bool Status_car { get; set; }
    }
}
