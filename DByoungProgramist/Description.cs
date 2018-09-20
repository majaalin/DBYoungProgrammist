using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace DByoungProgramist
{
    public class Description
    {
        

        [XmlAttribute ("Id")]
        public int Id { get; set; }
        [XmlElement ("Nazwa")]
        public string Name { get; set; }
        [XmlElement("Opis")]
        public string ShortDescription { get; set; }
        [XmlElement("Zawartość")]
        public string LongDescription { get; set; }
        [XmlElement("nrKategorii")]
        public int IdCategory { get; set; }

        public Description()
        {

        }

        public Description (int id,string n, string shortN, string longN,int idC)
        {
            this. Id = id;
            this.Name = n;
            this.ShortDescription = shortN;
            this.LongDescription = longN;
            this.IdCategory = idC;
        }

      

        public static void add(Description objekt)
        {
            var db = Db.connect();
            var col = db.GetCollection<Description>("Description");
            col.Insert(objekt);
        }
        //wypełnij
        public static dynamic getAll()
        {
            var db = Db.connect();
            var col = db.GetCollection<Description>("Description");
            return col.FindAll();
        }
        //usuń
        public static void del(int id)
        {
            var db = Db.connect();
            var col = db.GetCollection<Description>("Description");
            col.Delete(id);

        }
        //znajdz po numerze ID
        public static Description getById(int id)
        {
            var db = Db.connect();
            var col = db.GetCollection<Description>("Description");
            return col.FindById(id);
        }
        //aktualizuj
        public static void update(Description p)
        {
            var db = Db.connect();
            var col = db.GetCollection<Description>("Description");
            col.Update(p);
        }

        public static void Export(string sciezka)
        {
            var db = Db.connect();
            var col = db.GetCollection<Description>("Description");
            var json = JsonSerializer.Serialize(new BsonArray(db.Engine.Find("Description")));
             
        }

        public static void Import(string sciezka)
        {
            var db = Db.connect();
            var col = db.GetCollection<Description>("Description");
            db.Engine.Insert(col, JsonSerializer.Deserialize(sciezka).AsArray.ToArray());
        }


        public static void ClearDb()
        {
            using (var db = Db.connect())
            {
                db.DropCollection("Description");
                db.Shrink();

            }

        }
        
    }
}
