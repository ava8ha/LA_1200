using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string antwort = "ja";
            do
            {
                int i = 0;
                int j = 0;
                int k = 0;
                string eingabe;
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

                wort1.Add("Katze");
                wort2.Add("cat");


                foreach (string item in wort1) 
                {
                    Console.WriteLine("Was bedeutet " + item + " übersetzt?");
                    eingabe = Console.ReadLine();

                    if (item == eingabe) //eig. wort2
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n" + eingabe);
                        Console.ForegroundColor = ConsoleColor.White;
                        j++;
                    }
                    else if (item != eingabe)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n" + eingabe);
                        //Korrektur
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
        }
    }
}
