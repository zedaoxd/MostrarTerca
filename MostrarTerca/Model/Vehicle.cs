using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarTerca.Model
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Manufacturing { get; set; }
        public string Color { get; set; }
        public string Fuel { get; set; }
        public bool Automatic { get; set; }
        public double Price { get; set; }
    }
}
