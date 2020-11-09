using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMysqlStudent
{
    class Repository
    {
        private readonly string connectionStringCreate;
        private readonly string connectionString;

        public Repository()
        {
            MySqlConnectionStringBuilder mcsb = new MySqlConnectionStringBuilder();
            mcsb.Server = "localhost";
            mcsb.Database = "test";
            mcsb.UserID = "root";
            mcsb.Password = "";
            mcsb.Port = 3307;
            mcsb.SslMode = MySqlSslMode.None;
            connectionStringCreate = mcsb.ToString();

            mcsb.Database = "tmpDatabase";
            connectionString = mcsb.ToString();
        }

        /// <summary>
        /// tmpDatabase adatbázis létehozása és legyen az adatbázis a munkaadatbázisunk
        /// </summary>
        public void initializeEmptyDatabase()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionStringCreate);
                connection.Open();

                //FELADAT a query megírása
                string query = "";
                MySqlCommand cmdCreate = new MySqlCommand(query, connection);
                cmdCreate.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Tábla elkészítése a projektben lévő sql fájl alapján
        /// </summary>
        public void createTable()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                string query = "";
                MySqlCommand cmdCreate = new MySqlCommand(query, connection);
                cmdCreate.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Tábla feltöltése egy listából
        /// </summary>
        /// <param name="listOfData">Adatok listája</param>
        public void fillTableWithData(List<Student> listOfData)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                //FELADAT

                connection.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Adatok lekérése az adatbázisból egy listába
        /// </summary>
        /// <returns>A lekért adatok listája</returns>
        private List<Student> getList()
        {
            List<Student> listOfTable = new List<Student>();
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                //FELADAT

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return listOfTable;
        }
        /// <summary>
        /// A táblában lévő adatok kiírása a képernyőre
        /// </summary>
        public void showTable()
        {
            Console.WriteLine("Aktuális táblaadatok:");
            foreach(Student item in getList())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Egy új rekord hozzáadása a táblához
        /// </summary>
        /// <param name="item"></param>
        public void add(Student item)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                //FELADAT
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return;
        }
        /// <summary>
        /// A táblában az adot id-jű rekord törlése
        /// </summary>
        /// <param name="id">A törlendő rekord azonosítója</param>
        public void remove(int id)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                //FELADAT
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return;
        }
        /// <summary>
        /// A táblában az adott id-jű rekord módosítása
        /// </summary>
        /// <param name="id">A módosítandó rekord azonosítója</param>
        /// <param name="newItem">A módosítás során a rekord új értékei</param>
        public void update(int id, Student newItem)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                //FELADAT
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return;
        }
        /// <summary>
        /// A tábla összes sorának törlése
        /// </summary>
        public void removeAll()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                //FELADAT
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return;
        }
        /// <summary>
        /// A tábla törlése az adatbázisból
        /// </summary>
        public void deleteTable()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                //FELADAT
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Az adatbázis törlése
        /// </summary>
        public void deleteDatabase()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                //FELADAT
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
    }
}
