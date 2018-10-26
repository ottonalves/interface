using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HerancaInterface.Models.Entities
{
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return "Rectangle color: "
                + Color +
                ", Width: "
                + Width.ToString("F2", CultureInfo.InvariantCulture) +
                ", Height: "
                + Height.ToString("F2", CultureInfo.InvariantCulture) +
                ", Area: "
                + area().ToString("F2", CultureInfo.InvariantCulture);
                

                ;
        }
    }
}
