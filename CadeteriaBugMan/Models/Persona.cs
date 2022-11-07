using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadeteriaBugMan.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public double Phone { get; set; }

        public Persona()
        {
            Id = 0;
        }
    }
}