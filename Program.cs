using System;

namespace VelocMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---Velocidade Média---");
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("Insira os seguintes dados para obter a velocidade média desejada!");
            Console.WriteLine();
            Console.Write("Distância em metros...:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            double distancia = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            Console.Write("Tempo em segundos...:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            double tempo = Convert.ToDouble(Console.ReadLine()); 
            Console.ResetColor();

            double VelocMedia = (distancia / tempo);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Velocidade média ={distancia / tempo:N} m/s");
            Console.ResetColor();
            Console.WriteLine();


        }
    }
}
