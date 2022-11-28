using System;
using System.Numerics;

namespace Act4_ExerciceSimple_NombreComplexe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double complexeNbr1;
            double complexeNbr2;
            double AjtComplexeNbr1;
            double AjtComplexeNbr2;
            
            Console.WriteLine("Bienvenue dans ce programme sur les complexes !");
            Console.WriteLine("");

            string reload = "oui";
            while (reload == "oui")
            {
                Console.WriteLine("Que vaut la partie réelle du complexe de départ ?");
                complexeNbr1 = double.Parse(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Que vaut la partie imaginaire du complexe de départ ?");
                complexeNbr2 = double.Parse(Console.ReadLine());
                Console.WriteLine("");

                NbrComplexe complexe = new NbrComplexe(complexeNbr1, complexeNbr2);

                Console.WriteLine("Le premier complexe : " + complexe.AfficheComplexe() + " a pour module : " + complexe.CalculeModule().ToString("f2"));
                Console.WriteLine("");


                Console.WriteLine("Encoder un second nombre complexe : ");
                Console.WriteLine("");

                Console.WriteLine("Que vaut la partie réelle du second complexe ?");
                AjtComplexeNbr1 = double.Parse(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Que vaut la partie imaginaire du second complexe ?");
                AjtComplexeNbr2 = double.Parse(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Le second complexe est : " + $"({AjtComplexeNbr1.ToString("f2")}, {AjtComplexeNbr2.ToString("f2")})");
                complexe.Ajout(AjtComplexeNbr1, AjtComplexeNbr2);
                Console.WriteLine("");

                Console.WriteLine("Le premier complexe devient : " + complexe.AfficheComplexe());
                Console.WriteLine("");

                Console.WriteLine("Voulez-vous rejouez ? (entrer oui)");
                reload = Console.ReadLine();
                Console.WriteLine("");
            }

        }
    }
}
