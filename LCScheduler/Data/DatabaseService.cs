using System.Collections.Generic;
using System.Linq;
using SQLite;

namespace LCScheduler.Data
{
    public class DatabaseService<T> where T : new()
    {
        public void Insert()
        {
            var db = new SQLiteConnection(DataExtender.DataBaseNameAndPath);
            db.Insert(this);
        }

        public void Update()
        {
            var db = new SQLiteConnection(DataExtender.DataBaseNameAndPath);
            db.Update(this);
        }

        public void Delete()
        {
            var db = new SQLiteConnection(DataExtender.DataBaseNameAndPath);
            db.Delete(this);
        }

        public static List<T> GetItems()
        {
            var db = new SQLiteConnection(DataExtender.DataBaseNameAndPath);
            List<T> itemList = db.Table<T>().ToList();
            return itemList;
        }
    }
}
