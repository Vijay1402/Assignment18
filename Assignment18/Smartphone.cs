using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    public class Smartphone : IConnectable, IRechargeable, IDisplayable
    {
        bool isConnect;
        int minutes;
        string display;
        public Smartphone(Boolean isConnect, int minutes, string display)
        {
            this.isConnect = isConnect;
            this.minutes = minutes;
            this.display = display;
        }

        void IRechargeable.Charge(int minutes)
        {
            Console.WriteLine($"Smartphone will take {minutes} minutes to charge fully");
        }

        bool IConnectable.Connect()
        {
            return isConnect;
        }

        string IDisplayable.Display()
        {
            return display;
        }
    }
}
