using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instânciando uma classe para obter um objeto//
            Random dice = new Random ();
            //Utiizando o método para ter uma sequencia de números aleatórios//
            int roll1 = dice.Next (1,10);
            int roll2 = dice.Next (11,20);
            int roll3 = dice.Next (21,30);

            Console.WriteLine($"Dado 1 : {roll1}");
            Console.WriteLine($"Dado 2 : {roll2}");
            Console.WriteLine($"Dado 3 : {roll3}");

            //Utilizando um método que me devolva o maior valor//
            int primeiroValor = 500;
            int segundoValor = 600;
            int maiorValor = Math.Max(primeiroValor,segundoValor);

            Console.WriteLine($"O maior valor é: {maiorValor}");
            
        }
    }
}
