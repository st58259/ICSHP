using System;
using System.Collections.Generic;
using System.Text;

namespace Delegat
{
    public class Student
    {
        public string Jmeno { get; set; }
        public int Cislo { get; set; }
        public Fakulta Fakulta { get; set; }

        public Student(string jmeno, int cislo, Fakulta fakulta)
        {
            Jmeno = jmeno;
            Cislo = cislo;
            Fakulta = fakulta;
        }

        public override string ToString()
        {
            return Jmeno + ", " + Cislo + ", " + Fakulta;
        }
    }
}
