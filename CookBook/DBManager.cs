using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using System.Windows.Input;

namespace CookBook {
    public class DBManager {

        public class DishFields {

            public int ID { get; set; }
            public string Name { get; set; }
            public string Composition { get; set; }

            public DishFields(int id, string name, string composition) {
                this.ID = id;
                this.Name = name;
                this.Composition = composition;
            }
            public DishFields() {
                this.ID = -1;
                this.Name = "Placeholder";
                this.Composition = "Placeholder";

            }
        }

        public DBManager() {
            using (var connection = new SQLiteConnection("Data Source=data.db")) {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = "CREATE TABLE IF NOT EXISTS Dishes(" +
                    "ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, " +
                    "Name TEXT NOT NULL," +
                    "Composition TEXT," +
                    "Picture BLOB)";
                command.ExecuteNonQuery();
            }
        }

        public static void AddRecord(DishFields dishFields) {
            using (var connection = new SQLiteConnection("Data Source=data.db")) {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = $"INSERT INTO Dishes (Name, Composition) VALUES ('{dishFields.Name}', '{dishFields.Composition}')";
                command.ExecuteNonQuery();
            }
        }
        
        public static List<DishFields> GetList() {
            List<DishFields> dishList = new List<DishFields>();
            using (var connection = new SQLiteConnection("Data Source=data.db")) {
                connection.Open();
                string sqlExpression = "SELECT * FROM Dishes";

                SQLiteCommand command = new SQLiteCommand(sqlExpression, connection);
                using (SQLiteDataReader reader = command.ExecuteReader()) {
                    if (reader.HasRows) {// если есть данные
                        while (reader.Read()) {  // построчно считываем данные
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            string composition = reader.GetString(2);
                            //var age = reader.GetValue(2);

                            DishFields dish = new DishFields(id, name, composition);
                            dishList.Add(dish);
                            //Console.WriteLine($"{id} \t {name} \t {age}");
                        }
                    }
                }
            }
            return dishList;
        }
    }
}
