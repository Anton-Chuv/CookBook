using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using System.Windows.Input;
using static CookBook.DBManager;

namespace CookBook {
    public class DBManager {

        public class DishFields {

            public int ID { get; set; }
            public string Name { get; set; }
            public string Composition { get; set; }
            public Image Picture { get; set; }

            public DishFields(int id, string name, string composition) {
                this.ID = id;
                this.Name = name;
                this.Composition = composition;
                this.Picture = null;
            }
            public DishFields(int id, string name, string composition, Image picture) {
                this.ID = id;
                this.Name = name;
                this.Composition = composition;
                this.Picture = picture;
            }
            public DishFields() {
                this.ID = -2;
                this.Name = "Placeholder";
                this.Composition = "Placeholder";
                this.Picture = null;

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
                byte[] imageBytes;
                imageBytes = ImageToByte(dishFields.Picture);
                string cmnd = $"INSERT INTO Dishes (Name, Composition, Picture) VALUES ('{dishFields.Name}', '{dishFields.Composition}', @0)";
                command.CommandText = cmnd;
                SQLiteParameter param = new SQLiteParameter("@0", System.Data.DbType.Binary);
                param.Value = imageBytes;
                command.Parameters.Add(param);
                command.ExecuteNonQuery();
            }
        }

        public static void DeleteRecord(int id) {
            using (var connection = new SQLiteConnection("Data Source=data.db")) {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = $"Delete FROM Dishes WHERE ID={id}";
                command.ExecuteNonQuery();
            }
        }

        public static void ChangeRecord(DishFields dishFields) {
            using (var connection = new SQLiteConnection("Data Source=data.db")) {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand();
                command.Connection = connection;
                byte[] imageBytes;
                imageBytes = ImageToByte(dishFields.Picture);
                string cmnd = $"UPDATE Dishes SET Name='{dishFields.Name}', Composition='{dishFields.Composition}', Picture=@0 WHERE ID={dishFields.ID}";
                command.CommandText = cmnd;
                SQLiteParameter param = new SQLiteParameter("@0", System.Data.DbType.Binary);
                param.Value = imageBytes;
                command.Parameters.Add(param);
                //command.CommandText = $"UPDATE Dishes SET Name='{dishFields.Name}', Composition='{dishFields.Composition}' WHERE ID={dishFields.ID}";
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
                            byte[] img = (reader.GetValue(3) is not System.DBNull) ? (byte[])reader.GetValue(3): null;
                            //var age = reader.GetValue(2);
                            Image picture;
                            if (img != null) 
                                picture = ByteToImage(img);
                            else
                                picture = null;
                            DishFields dish = new DishFields(id, name, composition, picture);
                            dishList.Add(dish);
                            //Console.WriteLine($"{id} \t {name} \t {age}");
                        }
                    }
                }
            }
            return dishList;
        }

        public static byte[] ImageToByte(Image image) {
            if (image == null)
                return null;
            using (MemoryStream ms = new MemoryStream()) {
                // Convert Image to byte[]
                image.Save(ms, image.RawFormat);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }
        public static Image ByteToImage(byte[] imageBytes) {
            // Convert byte[] to Image
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);
            return image;
        }
    }
}
