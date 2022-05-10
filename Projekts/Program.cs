/*   Programma "C-Sharp Tutorial for beginners" tiek veidota, lai palīdzētu iesācējiem izprast/atkārtot  
Microsoft radītas objektu orientētas programmēšanas valodas C-Sharp pamatus.

  Šajā sadaļā tiek apskatīti(ar paskaidrojumiem):

* Primitīvie datu tipi    (Data Types)
* Aritmētiskie operatori  (Arithmetic Operators)
* Relāciju operatori      (Relational Operators)
* Loģiskie operatori      (Logical Operators)
* Piešķiršanas operatori  (Unary Operators)
*/
/*
Console.WriteLine("Kā tevi sauc ?");
string userInput = Console.ReadLine();
Console.WriteLine("Sveiks, " + userInput); */

using Projekts;
Menu menu = new Menu();
Console.WriteLine("Izvēlies 1 2 3 4 5 ");
string userInput = Console.ReadLine();
menu.Name = userInput;
menu.Izveelne();

















