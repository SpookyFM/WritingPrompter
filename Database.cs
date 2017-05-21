using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WritingPrompter
{
    /// <summary>
    /// Manages the sentence database
    /// </summary>
    public class Database
    {
        public List<GrammarPoint> GrammarPoints
        {
            get;
            set;
        }

        public List<Category> Categories
        {
            get;
            set;
        }

        public Database()
        {
            GrammarPoints = new List<GrammarPoint>();
            Categories = new List<Category>();
        }

        public void SaveToFile(String FullPath)
        {
            XmlSerializer Serializer = new XmlSerializer(typeof(Database));
            TextWriter Writer = new StreamWriter(FullPath);
            Serializer.Serialize(Writer, this);
        }

        public void LoadFromFile(String FullPath)
        {
            XmlSerializer Serializer = new XmlSerializer(typeof(Database));
            TextReader Reader = new StreamReader(FullPath);
            Database DeserializedDB = Serializer.Deserialize(Reader) as Database;
            GrammarPoints = DeserializedDB.GrammarPoints;
            Categories = DeserializedDB.Categories;
        }
    }
}
