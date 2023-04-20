using System.Xml;

namespace XmlDocument
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"D:\\user\\rehber4.xml";
            XmlTextWriter xmlWriter = new XmlTextWriter(fileName, System.Text.Encoding.UTF8);
            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Kitaplar");

            xmlWriter.WriteStartElement("Kitap");
            xmlWriter.WriteElementString("Ad", "Sefiller");
            xmlWriter.WriteElementString("Yazar", "Victor Hugo");
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("Kitap");
            xmlWriter.WriteElementString("Ad", "Savaş ve Barış");
            xmlWriter.WriteElementString("Yazar", "Lev Tolstoy");
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("dergi");
            xmlWriter.WriteElementString("Ad", "AA");
            xmlWriter.WriteElementString("Yazar", "BB"); 
            xmlWriter.WriteEndElement();
    
            xmlWriter.WriteEndDocument();
            xmlWriter.Flush();
            xmlWriter.Close();
        }
    }
}