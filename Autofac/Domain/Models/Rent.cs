using System;

namespace Domain
{
    public class Rent
    {
        public long Id { get; set; }
        public Car Car { get; set; }
        public DateTime RentDate { get; set; }
        public double RentPrice { get; set; }
    }
}
