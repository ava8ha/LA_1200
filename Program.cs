using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;





namespace Voci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string antwort = "ja";
            string antwort2 = "ja";
            do
            {
                int i = 0;
                int j = 0;
                int k = 0;
                List<string> wort1 = new List<string>();
                List<string> wort2 = new List<string>();





                Console.WriteLine("Voci lernen einfach gemacht\n\n");
                do
                {
                    Console.Write("Geben sie ein Wort ein: ");
                    wort1.Add(Console.ReadLine());
                    Console.Write("Geben sie die Übersetzung ein: ");
                    wort2.Add(Console.ReadLine());
                    i++;
                    Console.Write("Möchten sie weitere Wörter eingeben? [ja|nein]");
                    antwort = Console.ReadLine();
                } while (antwort == "ja");




                do
                {
                    j = 0;
                    for (int l = 0; l < wort1.Count; l++)
                    {
                        Console.WriteLine("Was bedeutet " + wort1[l] + " übersetzt?");
                        string eingabe = Console.ReadLine();





                        if (eingabe == wort2[l]) //eig. wort2
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n" + eingabe);
                            Console.WriteLine(wort2[l]);
                            Console.ForegroundColor = ConsoleColor.White;
                            j++;
                        }
                        else if (eingabe != wort2[l])
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n" + eingabe);
                            Console.WriteLine(wort2[l]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }







                    k = (100 / i) * j;
                    Console.WriteLine("Sie haben alle Wörter geübt");
                    Console.WriteLine("Es waren " + j + " von " + i + " Wörtern richtig");
                    Console.WriteLine("Das sind " + k + "%");
                    Console.Write("Möchten sie die Wörter nochmal üben? [ja|nein]");
                    antwort = Console.ReadLine();
                } while (antwort == "ja");





                Console.Write("Möchten sie neue Wörter üben? [ja|nein]");
                antwort2 = Console.ReadLine();
            } while (antwort2 == "ja");
        }
    }
}

