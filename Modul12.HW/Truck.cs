using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12.HW
{
  public class Truck : Car
    {
        public Truck(string name) : base(name, new Random().Next(2, 8)) { }
    }

}
