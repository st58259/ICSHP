using System;
using BaseLib;
using Delegat;

namespace cv03
{
    public class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(BaseLib.ExtraMath.GenerateDouble(new Random(), 1, 10));

            bool succ = BaseLib.ExtraMath.QuadraticEquation(2, 3, 1.125, out double x1, out double x2);
            Console.WriteLine(succ + "\nx1 = " + x1 + "\nx2 = " + x2);


            bool exit = false;

            string menu = "\n\n1.Načtení studentů z klávesnice \n";
            menu += "2.Výpis studentů na obrazovku\n";
            menu += "3.Seřazení studentů podle čísla\n";
            menu += "4.Seřazení studentů podle jména\n";
            menu += "5.Seřazení studentů podle fakulty\n";
            menu += "6.Vlož předdefinované studenty\n";
            menu += "0.Konec programu\n\n";


            Studenti s = new Studenti(10);

            while (!exit)
            {
                Console.WriteLine(menu);

                try
                {

                    int input = Reading.ReadInt("Příkaz");

                    switch (input)
                    {
                        case 1:
                            s.AddStudent();
                            break;
                        case 2:
                            s.PrintStudents();
                            break;
                        case 3:
                            s.SortStudents(s.SortTwoStudentsByNumber);
                            break;
                        case 4:
                            s.SortStudents(s.SortTwoStudentsByName);
                            break;
                        case 5:
                            s.SortStudents(s.SortTwoStudentsByFakulty);
                            break;
                        case 6:
                            s.GenStudents();
                            break;
                        case 0:
                            System.Environment.Exit(1);
                            break;
                        default:
                            break;
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("\n\nNesprávný příkaz !");
                    continue;
                }

            }


        }
    }
}
