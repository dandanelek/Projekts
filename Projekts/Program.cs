/*   Programma "C-Sharp Tutorial for beginners" tiek veidota, lai palīdzētu iesācējiem izprast/atkārtot  
Microsoft radītas objektu orientētas programmēšanas valodas C-Sharp pamatus.

  Šajā sadaļā tiek apskatīti(ar paskaidrojumiem):

* a.Primitīvie datu tipi    (Data Types)
* b.Aritmētiskie operatori  (Arithmetic Operators)
* c.Relāciju operatori      (Relational Operators)
* d.Loģiskie operatori      (Logical Operators)
* e.Piešķiršanas operatori  (Unary Operators)
*/
/*
Console.WriteLine("Kā tevi sauc ?");
string userInput = Console.ReadLine();
Console.WriteLine("Sveiks, " + userInput); */

using Projekts;
Menu menu = new Menu();
Console.WriteLine("                                                   ");
Console.WriteLine("   Šajā sadaļā tiek apskatīti(ar paskaidrojumiem):");
Console.WriteLine("                                                   ");
Console.WriteLine("   a.Primitīvie datu tipi    (Data Types)");
Console.WriteLine("   b.Aritmētiskie operatori  (Arithmetic Operators)");
Console.WriteLine("   c.Relāciju operatori      (Relational Operators)");
Console.WriteLine("   d.Loģiskie operatori      (Logical Operators)");
Console.WriteLine("   e.Piešķiršanas operatori  (Unary Operators)");
Console.WriteLine("                                                   ");
Console.WriteLine(" Izvēlieties no saraksta: a b c d vai e");
string userInput = Console.ReadLine();
menu.Name = userInput;
menu.Izveelne();

















