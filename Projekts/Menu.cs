using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekts
{
    public class Menu
    { 
        public string Name {get; set;}
        public void Izveelne()
        {
            string caseSwitch = "${}";
            switch (Name)
            {
                case string A:
                    Console.WriteLine("Monday");
                    break;
                case string B:
                    Console.WriteLine("Tuesday");
                    break;
                case string C:
                    Console.WriteLine("Wednesday");
                    break;
                case string D:
                    Console.WriteLine("Thursday");
                    break;
                case string E:
                    Console.WriteLine("Friday");
                    break;  
               
            }  
           // Console.WriteLine($"Jūs esiet izvēlējies ārpus saraksta");
        }
}
}
