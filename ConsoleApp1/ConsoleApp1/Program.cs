using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ILecteurMusique lecteurMusique = new LecteurMusique();

            lecteurMusique.Jouer("barbareintro.wav");

            Console.WriteLine("pewpewpewpew");

            Console.ReadKey();
        }
    }
}
