using PizzeriaRendeles;
using System.IO.Pipes;
List<Rendeles> rendelesek = new List<Rendeles>();
foreach(var sor in File.ReadAllLines("rendelesek.txt"))
{
    rendelesek.Add(new Rendeles(sor));
}
Console.WriteLine("Napi rendelesek:");
foreach (var rendeles in rendelesek)
{
    Console.WriteLine(rendeles);
}
Console.WriteLine("\nStatisztika:");
int osszesBevetel = rendelesek.Sum(a => a.FizetendoDij());
var legtob = rendelesek.MaxBy(a => a.PizzaSzama);
Console.WriteLine($"Pizzéria teljes napi bevétele: {osszesBevetel} Ft");
Console.WriteLine($"Legtöbb pizzát rendelő vásárló: {legtob.VevoNev} ({legtob.PizzaSzama} db)");