using HerancaInterface.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HerancaInterface.Models.Entities
{
    abstract class AbstractShape: IShape
    {
        public Color Color { get; set; }
        public abstract double area(); //Declaraçã do método abstrato
    }
}
