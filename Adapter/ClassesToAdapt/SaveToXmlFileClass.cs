using System.IO;
using System.Xml.Serialization;
using System;

namespace Adapter
{
    public class SaveToXmlFileClass
    {
        private const string PATH_EXTENSION = ".xml";

        private string Data { get; set; } = null!;

        private XmlSerializer xmlFormatter;

        public SaveToXmlFileClass()
        {
             xmlFormatter = new XmlSerializer(typeof(string));
        }

        public void Create(string path)
        {
            using (var file = new FileStream(path + PATH_EXTENSION, FileMode.Create))
            {
                xmlFormatter.Serialize(file, Data);
            }
        }

        public string Open(string path)
        {
            using (var file = new FileStream(path + PATH_EXTENSION, FileMode.Open))
            {
                string result = string.Empty;
                var text = xmlFormatter.Deserialize(file) as string;
                if (text != null)
                {
                    foreach (var item in text)
                    {
                        result += item;
                    }
                }
                return result;
            }
        }

        public void SetData(string data)
        {
            Data = data;
        }
    }
}
