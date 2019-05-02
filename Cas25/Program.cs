using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cas25
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deo1();
            //Deo2();
            //Deo3();
            //Deo4();
            Deo5();

            Console.ReadLine();
        }
        static void Deo5()
        {
            FileClass fc = new FileClass();
            // Ukoliko ne postoji, potrebno je da napravite novi folder C:\Kurs
            fc.SetFileName("C:\\Kurs\\Cas25.txt");
            fc.WriteToFile("Övo je neki tekst koji zelimo da upisemo u fajl, i koji ce biti dodat na kraj.");
        }

        static void Deo4()
        {
            
            using (StreamReader file = new StreamReader("C:\\Kurs\\Cas25.txt"))
            {
                while(true)
                {
                    string line = file.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    if (line.Contains("KLJUCNU"))
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            
        }


        static void Deo3()
        {
            int[] values = new int[5];
            ConsoleClass.ReadInput(5, out values);

            using (StreamWriter file = new StreamWriter("C:\\Kurs\\Cas25.txt"))
            {
                for (int i = 0; i < values.Length; i++)
                {
                    file.WriteLine("Vrednost {0} je {1}", i, values[i]);
                }
            }
        }

        static void Deo2()
        {
            using (StreamWriter file = new StreamWriter("C:\\Kurs\\Cas25.txt"))
            {
                file.Write("Ovo je ");
                file.WriteLine("prvi red.");
                file.WriteLine("Drugi red.");
            }

            using (StreamWriter file = new StreamWriter("C:\\Kurs\\Cas25.txt", true))
            {
                file.WriteLine("Treci red, dodat (append).");
            }
        }

        static void Deo1()
        {
            int[] values = new int[7];
            ConsoleClass.ReadInput(7, out values);

            double avg;
            avg = MathClass.Average(values);

            Console.WriteLine("Srednja vrednost unetih brojeva je {0}", avg);
        }



    }
}
