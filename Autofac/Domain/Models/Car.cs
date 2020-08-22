using System.Collections.Generic;

namespace Domain
{
    public class Car
    {
        public long Id { get; set; }
        public string Model { get; set; }
        public Color Color { get; set; }
        public Type Type { get; set; }
        public Brand Brand { get; set; }
        public IEnumerable<Rent> Rents { get; set; }
    }
}
