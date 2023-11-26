using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12.HW
{
    public class Bus : Car
    {
        public Bus(string name) : base(name, new Random().Next(1, 5)) { }
    }

}
