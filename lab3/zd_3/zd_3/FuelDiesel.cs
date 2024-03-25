using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd_3
{
    internal class FuelDiesel :Fuel
    {
        private bool canIRunMyOldPassat;
        public FuelDiesel()
        {
            density = 0.6;
            material = "Diesel";
        }

        //public override string Material
        //{
        //    get { return material; }
        //}

    }
}
