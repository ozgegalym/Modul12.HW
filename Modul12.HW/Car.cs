using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12.HW
{
    public abstract class Car
    {
        public string Name { get; set; }
        public int Position { get; set; }
        public int Speed { get; set; }

        public event EventHandler<string> Finish;

        public Car(string name, int speed)
        {
            Name = name;
            Speed = speed;
            Position = 0;
        }

        public void Move()
        {
            Position += Speed;
            if (Position >= 100)
            {
                OnFinish();
            }
        }

        protected virtual void OnFinish()
        {
            Finish?.Invoke(this, $"{Name} пришел к финишу!");
        }
    }

}
