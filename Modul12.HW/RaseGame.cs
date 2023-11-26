using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12.HW
{
    public class RaceGame
    {
        public delegate void RaceEventHandler();

        public event RaceEventHandler StartRace;

        public void Start()
        {
            StartRace?.Invoke();
        }

        public void RaceInfo(object sender, string message)
        {
            Console.WriteLine($"{((Car)sender).Name}: {message}");
        }

        public void WinnerInfo(object sender, string message)
        {
            Console.WriteLine($"Победитель: {((Car)sender).Name}");
        }
    }

}
