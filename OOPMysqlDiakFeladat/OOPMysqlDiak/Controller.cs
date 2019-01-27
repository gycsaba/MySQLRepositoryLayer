using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPMysqlStudent
{
    class Controller
    {
        private readonly string connectionStringCreate;
        private readonly string connectionString;

        public Controller()
        {
            connectionStringCreate =
                "SERVER=\"localhost\";"
                + "DATABASE=\"test\";"
                + "UID=\"root\";"
                + "PASSWORD=\"\";"
                + "PORT=\"3307\";";
            connectionString =
                "SERVER=\"localhost\";"
                + "DATABASE=\"tmpDatabase\";"
                + "UID=\"root\";"
                + "PASSWORD=\"\";"
                + "PORT=\"3307\";";
        }

        /// <summary>
        /// tmpDatabase adatbázis és abban tábla létehozása
        /// tábla feltöltése kezdőértékekkel
        /// </summary>
        public void initializeEmptyDatabase()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionStringCreate);
                connection.Open();

                string query = "CREATE DATABASE tmpDatabase DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;USE tmpDatabase";
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
        /// Tábla kezdőadatokkal való feltöltése
        /// </summary>
        /// <param name="listOfData">Adatok listája</param>
        public void pubDataInTable(List<Student> listOfData)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                //FELADAT
                string query = "";
                MySqlCommand cmdCreate = new MySqlCommand(query, connection);
                cmdCreate.ExecuteNonQuery();

                foreach (Student d in listOfData)
                {
                    query = d.getMysqlInsertCommand();
                    MySqlCommand cmdInsert = new MySqlCommand(query, connection);
                    cmdInsert.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Adatok lekérése az adatbázisból
        /// </summary>
        /// <returns>A lekért adatok listája</returns>
        private List<Student> getList()
        {
            List<Student> listOfTable = new List<Student>();
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                string query = "SELECT * FROM student";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader;
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int id = Convert.ToInt32(dataReader["id"].ToString());
                    string name = dataReader["name"].ToString();
                    double gradesAVG = Convert.ToDouble(dataReader["gradesAVG"].ToString());
                    Student item = new Student(id,name, gradesAVG);
                    listOfTable.Add(item);
                }                
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
        /// Egy új elem hozzáadása a táblához
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
        /// A táblában az adot id-jű elem törlése
        /// </summary>
        /// <param name="id">A törlendő elen azonosítója</param>
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
        /// A táblában az adott id-jű elem módosítása
        /// </summary>
        /// <param name="id">A módosítandó elem azonosítója</param>
        /// <param name="newItem">A módosítás során ezek lesznek az új értékek</param>
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
        /// A tábla törlése
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
