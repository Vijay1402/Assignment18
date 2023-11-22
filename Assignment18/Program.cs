using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool cl, cs;
            Console.WriteLine("Enter laptop details:");
            Console.WriteLine("Confirm if device is charging: Y/N");
            if(Console.ReadLine().ToLower()=="y")
            {
                cl = true;
            }
            else
            {
                cl = false;
            }
            Console.WriteLine("Enter total charging time in minutes");
            int minl = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter display type");
            string displ = Console.ReadLine();
            Console.WriteLine("Enter Smartphone details:");
            Console.WriteLine("Confirm if device is charging: Y/N");
            if (Console.ReadLine().ToLower() == "y")
            {
                cs = true;
            }
            else
            {
                cs = false;
            }
            Console.WriteLine("Enter total charging time in minutes");
            int mins = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter display type");
            string disps = Console.ReadLine();

            Laptop objL = new Laptop(cl,minl,displ);
            IConnectable icl = objL;
            IRechargeable irl = objL;
            IDisplayable idl = objL;
            if (icl.Connect())
            {
                Console.WriteLine("The Laptop device is connected.");
            }
            else
            {
                Console.WriteLine("The Laptop device is not connected.");
            }
            irl.Charge(minl);
            Console.WriteLine($"The laptop has {idl.Display()} type.");
            Console.WriteLine("\n");
            
            Smartphone objS = new Smartphone(cs, mins, disps);
            IConnectable ics = objS;
            IRechargeable irs = objS;
            IDisplayable ids = objS;
            if (ics.Connect())
            {
                Console.WriteLine("The Smartphone device is connected.");
            }
            else
            {
                Console.WriteLine("The Smartphone device is not connected.");
            }
            irs.Charge(mins);
            Console.WriteLine($"The Smartphone has {ids.Display()} type.");
            Console.ReadKey();  

        }
    }
}
