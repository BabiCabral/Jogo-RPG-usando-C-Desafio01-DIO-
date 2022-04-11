using System;
using DesafioProjeto01.src.Entities;

namespace DesafioProjeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 22, "Knight");
            Wizard jennica = new Wizard("Jennica", 24, "White Wizard");
            Wizard topapa = new Wizard("Topapa", 42, "Black Wizard");
            Ninja Wedge = new Ninja("Wedge", 35, "Ninja");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(jennica.Attack(1));
            Console.WriteLine(topapa.Attack(7));
            Console.WriteLine(Wedge.Attack(2));
            Console.WriteLine(Wedge.Attack(9));

        }
    }
}
