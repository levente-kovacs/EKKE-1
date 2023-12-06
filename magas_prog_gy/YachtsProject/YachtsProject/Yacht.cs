using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YachtsProject
{
    internal class Yacht
    {
        public string Model { get; set; }
        public float Price { get; set; }

        public Yacht(string model, float price)
        {
            Model = model;
            Price = price;
        }

        public override string? ToString()
        {
            return $"A jacht modellje: {Model}\nA jacht ára: {Price}";
        }
    }
}
