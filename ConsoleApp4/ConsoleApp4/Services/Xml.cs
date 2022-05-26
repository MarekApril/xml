using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ConsoleApp4.Models;

namespace ConsoleApp4.Services
{
    public class Xml
    {
        public Document_Order Deserialize()
        {
            var xmlSerializer = new XmlSerializer(typeof(Document_Order));
            using (var reader = new StreamReader(@"C:\TMP\xmltest\test3.xml"))
            {
                var deserialize = (Document_Order) xmlSerializer.Deserialize(reader);
                return deserialize;
            }
        }

        public void Serialize(string path, Document_Order document)
        {
            var xmlSerializer = new XmlSerializer(typeof(Document_Order));
            using (var write = new StreamWriter($"{path}"))
            {
                xmlSerializer.Serialize(write, document);
            }
        }

        public List<Document_Order> DeserializeAll()
        {
            string[] files = Directory.GetFiles(@"C:\TMP\xml1");

            var documents = new List<Document_Order>();

            var xmlSerializer = new XmlSerializer(typeof(Document_Order));

            foreach (var result in files)
            {
                using (var reader = new StreamReader(result))
                {
                    documents.Add((Document_Order) xmlSerializer.Deserialize(reader));
                }
            }

            return documents;
        }
    }
}
