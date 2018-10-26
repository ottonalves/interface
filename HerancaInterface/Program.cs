using HerancaInterface.Models.Entities;
using HerancaInterface.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle() { Radius = 2.0, Color = Color.Black };
            IShape s2 = new Rectangle() { Width = 9.6, Height = 5.2, Color = Color.White };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
