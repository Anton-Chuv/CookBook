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
            public string Property { get; set; }

            public DishFields(int id, string name, string property) {
                ID = id;
                Name = name;
                Property = property;
            }
            public DishFields() {
                ID = -1;
                Name = "Placeholder";
                Property = "Placeholder";

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
                    "Property TEXT," +
                    "Picture BLOB)";
                command.ExecuteNonQuery();
            }
        }

        
    }
}
