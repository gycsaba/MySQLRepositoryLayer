using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMysqlStudent
{
    partial class Student
    {
        private int id;
        private string name;
        private double gradesAVG;

        public Student(int id, string name, double gradesAVG)
        {
            this.id = id;
            this.name = name;
            this.gradesAVG = gradesAVG;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setMark(double mark)
        {
            this.gradesAVG = mark;
        }
        public string getName()
        {
            return name;
        }
        public double getMark()
        {
            return gradesAVG;
        }
        public int getID()
        {
            return id;
        }
        /// <summary>
        /// Az osztály adataibból szöveges adatot készít
        /// </summary>
        /// <returns>Az osztály adatai és kísérő szöveg</returns>
        public override string ToString()
        {
            return id+". "+name+" diák jegye"+gradesAVG;
        }
    }
}
