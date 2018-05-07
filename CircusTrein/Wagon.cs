using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    class Wagon
    {
        public List<Animal> animals;
        
        public int punten;
        
        public Wagon()
        {
            animals = new List<Animal>();
        }

        public override string ToString()
        {
            string returner = "wagonPunten: " + punten;
            foreach (var animal in animals)
            {
                returner = returner  + " grootte: " + animal.grootte + " type: " + animal.type + " punten: " + animal.punt + " | ";
            }
            return returner;
        }

    }
}
