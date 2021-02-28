using System;
using System.Collections.Generic;
using System.Linq;
using Fei.BaseLib;

namespace Arrays
{
    class Program
    {

        private static int[] arr;


        static void Main(string[] args)
        {
            bool exit = false;

            string menu = "\n\n1.Zadaní prvků pole z klávesnice \n";
            menu += "2.Výpis pole na obrazovku\n";
            menu += "3.Utřídění pole vzestupně\n";
            menu += "4.Hledání minimálního prvku\n";
            menu += "5.Hledání prvního výskytu zadaného čísla\n";
            menu += "6.Hledání posledního výskytu zadaného čísla\n";
            menu += "8.Utřídění pole sestupně\n";
            menu += "7.Konec programu\n\n";


            while (!exit)
            {
                Console.WriteLine(menu);

                try
                {

                    int input = Reading.ReadInt("Příkaz");

                    switch (input)
                    {
                        case 1:
                            CreateArray();
                            break;
                        case 2:
                            PrintArray();
                            break;
                        case 3:
                            SortArray();
                            break;
                        case 4:
                            MinArray();
                            break;
                        case 5:
                            FirstArray();
                            break;
                        case 6:
                            LastArray();
                            break;
                        case 8:
                            SortArrayDesc();
                            break;
                        case 7:
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


        private static void CreateArray()
        {
            int arrLength = Reading.ReadInt("Délka pole");
            arr = new int[arrLength];


            for (int i = 0; i < arrLength; i++)
            {
                arr[i] = Reading.ReadInt(">");
            }
        }

        private static void PrintArray()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        private static void SortArray()
        {
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        private static void SortArrayDesc()
        {
            Array.Sort(arr);
            Array.Reverse(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        private static void MinArray()
        {
            Console.WriteLine(arr.Min());
        }

        private static void MaxArray()
        {
            Console.WriteLine(arr.Max());
        }

        private static void FirstArray()
        {
            int input = Reading.ReadInt("Hledané číslo");

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == input)
                {
                    Console.WriteLine("Pozice : " + i);
                    return;
                }
            }
        }

        private static void LastArray()
        {
            int input = Reading.ReadInt("Hledané číslo");

            for (int i = arr.Length; i > 0; i--)
            {
                if (arr[i] == input)
                {
                    Console.WriteLine("Pozice : " + i);
                    return;
                }
            }
        }


    }


}
