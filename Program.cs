using System;
using Projeto_RPG.src.Entities;

namespace abstracao_rpg{
    class Program
    {
        static void Main(string[] args){
            Knight Arus = new Knight("Arus",23,"Knights");
            Wizard Jannica = new Wizard("Jannica", 23, "Wizard");
            Ninja Wedge = new Ninja("Wedge", 42,"Ninja");
            BlackWizard Topapa = new BlackWizard ("Topapa", 66, "Black Wizard");
            Console.WriteLine(Arus.Attack(1));
            Console.WriteLine(Jannica.Attack(3));
            Console.WriteLine(Wedge.Level);
            Console.WriteLine(Topapa.HeroType);

        }
    }
}