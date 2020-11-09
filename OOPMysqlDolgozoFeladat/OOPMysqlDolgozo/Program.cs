using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMysqlDolgozo
{
    class Program
    {
        static void Main(string[] args)
        {


            Controller c = new Controller();
            c.initializeEmptyDatabase();

            List<Employee> employes;
            employes = new List<Employee>();
            employes.Add(new Employee(1, "Késő Kenéz", 21));
            employes.Add(new Employee(2, "Szorgalmas Szonja", 22));
            employes.Add(new Employee(3, "Programozó Péter", 23));
            c.fillTableWithData(employes);

            c.showTable();
            c.add(new Employee(4,"Vezető Vera", 27));
            c.add(new Employee(5,"Takarító Teri", 22));
            c.showTable();
            c.remove(2);
            c.showTable();
            c.update(5, new Employee(6,"Seprű Sándor", 24));                        
            c.showTable();
            Console.ReadKey();
            c.removeAll();
            c.showTable();
            c.deleteTable();
            c.deleteDatabase();
        }
    }
}
