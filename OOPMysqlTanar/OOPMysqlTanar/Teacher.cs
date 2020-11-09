using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMysqlTanar
{
    class Teacher
    {
        private int id;
        private string name;
        private int salary;

        public Teacher(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setSalary(int salary)
        {
            this.salary = salary;
        }
        public string getName()
        {
            return name;
        }
        public int getSalary()
        {
            return salary;
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
            return id+". "+name+" tanár havi fizetése "+salary;
        }
        /// <summary>
        /// Elkészíti az SQL INSERT utasítást
        /// Az INSERT utasítás a tábla sorai közé beszúrja az osztály mezőket
        /// </summary>
        /// <returns>SQL INSERT utasítás</returns>
        public string getMysqlInsertCommand()
        {
            return "INSERT INTO `teacher` (`id`, `name`, `salary`) VALUES ('" +
                id +
                "', '" +
                name +
                "', '" +
                salary +
                "');";
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
            return "UPDATE `teacher` SET `id` = '" +
                this.id +
                "', `name` = '" +
                name +
                "', `age` = '" +
                salary +
                "' WHERE `teacher`.`id` = " +
                id;
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
            return "DELETE FROM teacher WHERE id=\"" + id+"\"";
        }
        /// <summary>
        /// Osztály metódus
        /// Elkészíti a DELETE FROM utasítást
        /// A DELETE FROM utasítást törtli a táblát
        /// </summary>
        /// <returns></returns>
        static public string getMysqlDeleteCommand()
        {
            return "DELETE FROM teacher";
        }


    }
}
