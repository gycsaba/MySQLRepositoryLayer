using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMysqlDolgozo
{
    class Employee
    {
        private int id;
        private string name;
        private int age;

        public Employee(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public string getName()
        {
            return name;
        }
        public int getAge()
        {
            return age;
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
            return id+". "+name+" dolgozó "+age+" éves";
        }
        /// <summary>
        /// FELADAT
        /// Elkészíti az SQL INSERT utasítást
        /// Az INSERT utasítás a tábla sorai közé beszúrja az osztály mezőket
        /// </summary>
        /// <returns>SQL INSERT utasítás</returns>
        public string getMysqlInsertCommand()
        {
            return "";
        }
        /// <summary>
        /// Elkészíti az SQL UPDATE utasítást
        /// Az UPDATE utasítás a táblában a praméterben megadott sort módosítja az osztály mezői alapján
        /// <returns>SQL INSERT utasítás</returns>
        /// </summary>
        /// <param name="id">A táblában annak a sornak a kulcsa, amelyiket módosítani kell</param>
        /// <returns></returns>
        public string getMysqlUpdateCommand(int id)
        {
            return "";
        }
        /// <summary>
        /// Osztály metódus
        /// Elkészíti a DELETE FROM utasítást
        /// A DELETE FROM utasítás törli a táblában az id által meghatározott sort
        /// </summary>
        /// <param name="id">A táblában annak a sornak a kulcsa, amelyiket törölni kell</param>
        /// <returns></returns>
        static public string getMysqlDeleteCommand(int id)
        {
            return "";
        }
        /// <summary>
        /// Osztály metódus
        /// Elkészíti a DELETE FROM utasítást
        /// A DELETE FROM utasítást törtli a táblát
        /// </summary>
        /// <returns></returns>
        static public string getMysqlDeleteCommand()
        {
            return "";
        }


    }
}
