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
           
            switch (Name)
            {
                case "a":
                    Console.WriteLine("Primitīvie datu tipi");
                    break;
                case "b":
                    Console.WriteLine("Aritmētiskie operatori");
                    break;
                case "c":
                    Console.WriteLine("Relāciju operatori");
                    break;
                case "d":
                    Console.WriteLine("Loģiskie operatori");
                    break;
                case "e":
                    Console.WriteLine("Piešķiršanas operatori");
                    break;
                default:  
                    Console.WriteLine($"Jūs esiet izvēlējies ārpus saraksta");
                    break;
            }  
           Console.WriteLine($"stop");
        }
}
}
