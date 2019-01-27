using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMysqlTanar
{
    class Program
    {
        static void Main(string[] args)
        {


            Controller c = new Controller();
            c.initializeEmptyDatabase();

            List<Teacher> employes;
            employes = new List<Teacher>();
            employes.Add(new Teacher(1, "Buktató Béla", 210000));
            employes.Add(new Teacher(2, "Szám Szonja", 22000));
            employes.Add(new Teacher(3, "Töri Tamás", 23000));
            c.pubDataInTable(employes);

            c.showTable();
            c.add(new Teacher(4,"Föci Feri", 27000));
            c.add(new Teacher(5,"Magyar Mari", 22000));
            c.showTable();
            c.remove(2);
            c.showTable();
            c.update(5, new Teacher(6,"Zene Zori", 24000));                        
            c.showTable();
            Console.ReadKey();
            c.removeAll();
            c.showTable();
            c.deleteTable();
            c.deleteDatabase();
        }
    }
}
