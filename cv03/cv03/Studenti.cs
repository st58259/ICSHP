using System;
using System.Collections.Generic;
using System.Text;
using BaseLib;

namespace Delegat
{
    public class Studenti
    {
        Student[] arr;
        int max;
        int cur;

        public Studenti(int max)
        {
            this.max = max;
            arr = new Student[max];
            cur = 0;
        }

        public void GenStudents()
        {
            Student s = new Student("Jack", 12, Fakulta.FEI);
            arr[cur] = s;
            cur++;
            s = new Student("Max", 24, Fakulta.FEI);
            arr[cur] = s;
            cur++;
            s = new Student("Carl", 5, Fakulta.FES);
            arr[cur] = s;
            cur++;
            s = new Student("Brian", 14, Fakulta.FCHT);
            arr[cur] = s;
            cur++;
        }

        public void AddStudent()
        {
            string name = Reading.ReadString("Jméno");
            int num = Reading.ReadInt("Cislo");
            string fak = Reading.ReadString("Fakulta");
            Fakulta fakulta = Fakulta.FEI;

            if (fak == "fes")
            {
                fakulta = Fakulta.FES;
            }
            if (fak == "ff")
            {
                fakulta = Fakulta.FF;
            }
            if (fak == "fei")
            {
                fakulta = Fakulta.FEI;
            }
            if (fak == "fcht")
            {
                fakulta = Fakulta.FCHT;
            }

            Student s = new Student(name, num, fakulta);
            arr[cur] = s;
            cur++;
        }

        public void PrintStudents()
        {
            for (int i = 0; i < cur; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public void SortStudents(SortDelegate sortBy)
        {
            Student temp;

            for (int j = 0; j <= cur - 2; j++)
            {
                for (int i = 0; i <= cur - 2; i++)
                {
                    //if (arr[i] > arr[i + 1])  // > 
                    if (sortBy(arr[i], arr[i + 1]) > 0)
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }

        public int SortTwoStudentsByNumber(Student a, Student b)
        {
            return a.Cislo.CompareTo(b.Cislo);
        }

        public int SortTwoStudentsByName(Student a, Student b)
        {
            return a.Jmeno.CompareTo(b.Jmeno);
        }

        public int SortTwoStudentsByFakulty(Student a, Student b)
        {
            return a.Fakulta.ToString().CompareTo(b.Fakulta.ToString());
        }


        public delegate int SortDelegate(Student a, Student b);









    }

    public enum Fakulta
    {
        FES,
        FF,
        FEI,
        FCHT
    }

}
