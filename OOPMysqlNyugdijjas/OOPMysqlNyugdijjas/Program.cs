using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMysqlPensioner
{
    class Program
    {
        static void Main(string[] args)
        {


            Controller c = new Controller();
            c.initializeEmptyDatabase();

            List<Pensioner> employes;
            employes = new List<Pensioner>();
            employes.Add(new Pensioner(1, "Beszélő Béla", 129000));
            employes.Add(new Pensioner(2, "Kerekező Kázmér", 150000));
            employes.Add(new Pensioner(3, "Teniszező Teri", 130000));
            c.fillTableWithData(employes);

            c.showTable();
            c.add(new Pensioner(4,"Sétáló Sára", 210000));
            c.add(new Pensioner(5,"Unokázó Ubul", 190000));
            c.showTable();
            c.remove(2);
            c.showTable();
            c.update(5, new Pensioner(6,"Barkácsoló Bálint", 180000));                        
            c.showTable();
            Console.ReadKey();
            c.removeAll();
            c.showTable();
            c.deleteTable();
            c.deleteDatabase();
        }
    }
}
