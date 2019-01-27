using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMysqlStudent
{
    class Program
    {
        static void Main(string[] args)
        {


            Controller c = new Controller();
            c.initializeEmptyDatabase();

            List<Student> employes;
            employes = new List<Student>();
            employes.Add(new Student(1, "Bukfenc Béla", 2.04));
            employes.Add(new Student(2, "Szorgalmas Szonja", 4.56));
            employes.Add(new Student(3, "Stréber Sára", 4.99));
            c.pubDataInTable(employes);

            c.showTable();
            c.add(new Student(4,"Kitünő Kenéz", 5.00));
            c.add(new Student(5,"Tesi Teri", 3.03));
            c.showTable();
            c.remove(2);
            c.showTable();
            c.update(5, new Student(6,"Számolós Sándor", 4.44));                        
            c.showTable();
            Console.ReadKey();
            c.removeAll();
            c.showTable();
            c.deleteTable();
            c.deleteDatabase();
        }
    }
}
