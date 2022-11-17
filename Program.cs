using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Vocabularytraining
{
    class Program
    {
        static List<string> englishWords = new List<string>();
        static List<string> germanWords = new List<string>();
        static int correctGuesses = 0;
        static int NumberOfWords = 0;
        static int Percent = 0;
        static void Main(string[] args)
        {

            static void inputWordsFromUser()
            {
                Console.WriteLine("Voci lernen einfach gemacht\n\n");
                germanWords = new List<string>();
                englishWords = new List<string>();
                NumberOfWords= 0;
                do
                {
                    Console.Write("Geben sie ein Wort ein: ");
                    englishWords.Add(Console.ReadLine());
                    Console.Write("Geben sie die Übersetzung ein: ");
                    germanWords.Add(Console.ReadLine());
                    NumberOfWords++;
                    Console.Write("Möchten sie weitere Wörter eingeben? [ja|nein] ");
                } while (Console.ReadLine() == "ja");
            }
                static void askWords()
                {
                correctGuesses = 0;
                    for (int l = 0; l < englishWords.Count; l++)
                    {
                        Console.WriteLine("Was bedeutet " + englishWords[l] + " übersetzt?");
                        string answer = Console.ReadLine();

                        if (answer == germanWords[l])
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n" + answer);
                            Console.WriteLine(germanWords[l]);
                            Console.ForegroundColor = ConsoleColor.White;
                            correctGuesses++;

                        }
                        else if (answer != germanWords[l])
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n" + answer);
                            Console.WriteLine(germanWords[l] + " wäre richtig gewesen");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }

                }

                static void Score()
                {
                    Percent = (100 / NumberOfWords) * correctGuesses;
                    Console.WriteLine("Sie haben alle Wörter geübt");
                    Console.WriteLine("Es waren " + correctGuesses + " von " + NumberOfWords + " Wörtern richtig");
                    Console.WriteLine("Das sind " + Percent + "%");
                }

            do {
                    inputWordsFromUser();
                do
                {
                    askWords();
                    Score();
                    Console.Write("Möchten sie die Wörter nochmal üben? [ja|nein] ");
                } while (Console.ReadLine() == "ja");

                Console.Write("Möchten sie neue Wörter üben? [ja|nein] ");
            } while (Console.ReadLine() == "ja");
        }
        
    }
}

