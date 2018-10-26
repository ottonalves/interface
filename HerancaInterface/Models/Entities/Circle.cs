using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HerancaInterface.Models.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double area()
        {
            return Math.PI * (Radius * Radius);
        }

        public override string ToString()
        {
            return "Circle color: "
                + Color + ", Radius: "
                + Radius.ToString("F2", CultureInfo.InvariantCulture) +
                ", Area: " +
                area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
