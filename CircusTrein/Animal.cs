using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    class Animal
    {              
        public string grootte;
        public string type;
        public int punt;


        public override string ToString()
        {
            string returner = "type: " + type + " grootte: " + grootte;

            return returner;
        }
    }
}
