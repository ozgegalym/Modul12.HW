using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12.HW
{
    public class SedanCar : Car
    {
        public SedanCar(string name) : base(name, new Random().Next(3, 10)) { }
    }

}
