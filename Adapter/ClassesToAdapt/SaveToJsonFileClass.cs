using System;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Adapter
{
    public class SaveToJsonFileClass
    {
        private const string PATH_EXTENSION = ".json";
        private string Data { get; set; } = null!;

        DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(string));

        public SaveToJsonFileClass() { }

        public void Create(string path)
        {
            using (var file = new FileStream(path + PATH_EXTENSION, FileMode.Create))
            {
                jsonFormatter.WriteObject(file, Data);
            }
        }

        public string Open(string path)
        {
            using (var file = new FileStream(path + PATH_EXTENSION, FileMode.Open))
            {
                string result = string.Empty;
                var text = jsonFormatter.ReadObject(file) as string;
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
