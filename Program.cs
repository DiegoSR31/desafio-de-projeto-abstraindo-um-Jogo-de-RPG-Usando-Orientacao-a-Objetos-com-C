using System;
using desafio_de_projeto_abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C.scr.Entities;

namespace desafio_de_projeto_abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C
{
    class Program
    {

        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 23, "Knight", 469, 749, 72, 72);
            Ninja Wedge = new Ninja("Wedge", 23, "Ninja", 292, 574, 89, 89);
            Wizard Jenica = new Wizard("Jenica", 23, "White Wizard", 325, 601, 474, 482);
            Wizard Topapa = new Wizard("Topapa", 23, "Black Wizard", 106, 385, 611, 641);

            Console.WriteLine(Arus);
            Console.WriteLine(Arus.Attack(1));
            Console.WriteLine(Arus.Attack(7));
            Console.WriteLine(Wedge);
            Console.WriteLine(Wedge.Attack(1));
            Console.WriteLine(Wedge.Attack(7));
            Console.WriteLine(Jenica);
            Console.WriteLine(Jenica.Attack(1));
            Console.WriteLine(Jenica.Attack(7));
            Console.WriteLine(Topapa);
            Console.WriteLine(Topapa.Attack(1));
            Console.WriteLine(Topapa.Attack(7));

        }
    }
}


