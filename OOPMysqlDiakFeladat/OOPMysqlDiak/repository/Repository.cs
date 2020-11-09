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
        /// Tábla elkészítése a projektben lévő sql fájl alapján
        /// </summary>
        public void createTable()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                string query = 
                    "CREATE TABLE `student` ("+
                    " `id` int(11) NOT NULL,"+
                    " `name` varchar(20) COLLATE utf8_hungarian_ci DEFAULT NULL,"+
                    " `gradesAVG` double DEFAULT NULL"+
                    " ) ENGINE = InnoDB DEFAULT CHARSET = utf8 COLLATE = utf8_hungarian_ci;" +
                    "ALTER TABLE `student`" +
                    " ADD PRIMARY KEY(`id`);" +
                    " COMMIT; ";                     
                    

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
                foreach (Student d in listOfData)
                {
                    string query = d.getMysqlInsertCommand();
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
        /// Adatok lekérése az adatbázisból egy listába
        /// </summary>
        /// <returns>A lekért adatok listája</returns>
        private List<Student> getList()
        {
            List<Student> listFromTable = new List<Student>();
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
                    listFromTable.Add(item);
                }
                connection.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return listFromTable;
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
                string query = item.getMysqlInsertCommand();
                MySqlCommand cmdInsert = new MySqlCommand(query, connection);
                cmdInsert.ExecuteNonQuery();
                connection.Close();
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
                string query = Student.getMysqlDeleteCommand(id);
                MySqlCommand cmdDelete= new MySqlCommand(query, connection);
                cmdDelete.ExecuteNonQuery();
                connection.Close();
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
                string query = newItem.getMysqlUpdateCommand(id);
                MySqlCommand cmdUpdate = new MySqlCommand(query, connection);
                cmdUpdate.ExecuteNonQuery();
                connection.Close();
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
                string query = Student.getMysqlDeleteAllCommand();
                MySqlCommand cmdUpdate = new MySqlCommand(query, connection);
                cmdUpdate.ExecuteNonQuery();
                connection.Close();
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
                string query = "DROP TABLE student;";
                MySqlCommand cmdDeleteTAble = new MySqlCommand(query, connection);
                cmdDeleteTAble.ExecuteNonQuery();
                connection.Close();
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
                string query = "DROP DATABASE tmpDatabase;";
                MySqlCommand cmdDeleteDatabase = new MySqlCommand(query, connection);
                cmdDeleteDatabase.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
    }
}
