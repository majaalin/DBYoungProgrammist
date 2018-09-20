using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DByoungProgramist
{
    class Category
    {
        public int Id;
        public string CategoryName;
        public static dynamic getAll()
        {
            var db = Db.connect();
            var col = db.GetCollection<Category>("Category");
            return col.FindAll();
        }
        public static void del(int id)
        {
            var db = Db.connect();
            var col = db.GetCollection<Category>("Category");
            col.Delete(id);

        }
        public static Category getById(int id)
        {
            var db = Db.connect();
            var col = db.GetCollection<Category>("Category");
            return col.FindById(id);
        }
    }
}
