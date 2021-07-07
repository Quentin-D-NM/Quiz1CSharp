using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz1
{
    class ForceCalc
    {
        public const double G = 6.67408e-11;
        private double object1;
        private double object2; 
        private double distance;
        private double gravitationalForce;

        public double Object1 { get { return object1; } set { object1 = value; } }
        public double Object2 { get { return object2; } set { object2 = value;  } }

        public double Distance { get { return distance; } set { distance = value; Calc(); } }

        public double GravitationalForace { get { return gravitationalForce; } private set { gravitationalForce = value; } }

        private void Calc()
        {
            GravitationalForace = G * ((Object1 * Object2) / Math.Pow(Distance, 2));
        }

    }
}
