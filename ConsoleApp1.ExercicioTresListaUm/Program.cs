using System;

namespace ConsoleApp1.ExercicioTresListaUm
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Dias de vida");
            while (true)
            {
               
                string nome;
                int idade, diasDeVida;

                Console.Write("Por favor, informe seu nome: ");
                nome = Console.ReadLine();

                Console.Write("\nAgora informe sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                diasDeVida = idade * 365;

                Console.WriteLine(nome + ", você já viveu " + diasDeVida + " dias");
                Console.WriteLine("=================================");

                Console.WriteLine("Aperte ENTER para fazer novamente");
                Console.ReadLine();

            }while(true);   
        }
    }
}
