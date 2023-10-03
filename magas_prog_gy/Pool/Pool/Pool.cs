using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pools
{
    internal class Pool
    {
        public double R { get; set; }
        public double H { get; set; }

        public double CalcVolume()
        {
            return R * R * Math.PI * H;
        }

        public Pool(double r, double h)
        {
            this.R = r;
            this.H = h;
        }

        public override string? ToString()
        {
            return $"radius {R}m and height {H}m";
        }
    }
}
