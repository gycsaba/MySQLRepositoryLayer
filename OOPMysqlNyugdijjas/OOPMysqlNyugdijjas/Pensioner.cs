using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMysqlPensioner
{
    class Pensioner
    {
        private int id;
        private string name;
        private double pension;

        public Pensioner(int id, string name, double pension)
        {
            this.id = id;
            this.name = name;
            this.pension = pension;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setPension(double pension)
        {
            this.pension = pension;
        }
        public string getName()
        {
            return name;
        }
        public double getPension()
        {
            return pension;
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
            return id+". "+name+" nyugdijjas nyugdijja"+pension;
        }
        /// <summary>
        /// Elkészíti az SQL INSERT utasítást
        /// Az INSERT utasítás a tábla sorai közé beszúrja az osztály mezőket
        /// </summary>
        /// <returns>SQL INSERT utasítás</returns>
        public string getMysqlInsertCommand()
        {
            return "INSERT INTO `pensioner` (`id`, `name`, `pension`) VALUES ('" +
                id +
                "', '" +
                name +
                "', '" +
                pension +
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
            return "UPDATE `pensioner` SET `id` = '" +
                this.id +
                "', `name` = '" +
                name +
                "', `pension` = '" +
                pension +
                "' WHERE `pensioner`.`id` = " +
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
            return "DELETE FROM pensioner WHERE id=\"" + id+"\"";
        }
        /// <summary>
        /// Osztály metódus
        /// Elkészíti a DELETE FROM utasítást
        /// A DELETE FROM utasítást törtli a táblát
        /// </summary>
        /// <returns></returns>
        static public string getMysqlDeleteCommand()
        {
            return "DELETE FROM pensioner";
        }


    }
}
