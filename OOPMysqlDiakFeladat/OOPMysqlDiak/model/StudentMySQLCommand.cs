﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMysqlStudent
{
    partial class Student
    {        
        public string getMysqlInsertCommand()
        {
            return "";
        }
        /// <summary>
        /// FELADAT
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
        /// FELADAT
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
        /// FELADAT
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
