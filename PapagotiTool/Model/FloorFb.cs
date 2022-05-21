using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapagotiTool.Model
{
    internal class FloorFb
    {
        public double? Current { get; set; }

        public double? Energy { get; set; }

        public double? Frequency { get; set; }

        public double? Humidity { get; set; }

        public double? Power { get; set; }

        public double? Voltage { get; set; }

        public double? Temperature { get; set; }

        public double? PF { get; set; }
        public DateTime? Time { get; set; }
    }
}
