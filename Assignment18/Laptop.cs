using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    public class Laptop: IConnectable, IRechargeable, IDisplayable
    {
        bool isConnect;
        int minutes;
        string display;
        public Laptop(Boolean isConnect, int minutes, string display) 
        {
            this.isConnect = isConnect;
            this.minutes = minutes;
            this.display = display;
        }

        void IRechargeable.Charge(int minutes)
        {
            Console.WriteLine($"Laptop will take {minutes} minutes to charge fully");
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
