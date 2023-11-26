using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12.HW
{
    public class SportsCar : Car
    {
        public SportsCar(string name) : base(name, new Random().Next(5, 15)) { }
    }

}
