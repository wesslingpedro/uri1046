using System;
using System.Globalization;

namespace testes_ec
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            int hinicial = int.Parse(valores[0]);
            int hfinal = int.Parse(valores[1]);

            int duracao;

            if (hinicial < hfinal)
            {
                duracao = hfinal - hinicial;
            }
            else
            {
                duracao = 24 - hinicial + hfinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");




        }

    }

}