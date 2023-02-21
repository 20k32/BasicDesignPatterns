using System.DirectoryServices.ActiveDirectory;
using System.IO;

namespace Adapter
{
    public class SaveToTxtFileClass
    {
        private const string PATH_EXTENSION = ".txt";
        private string Data { get; set; } = null!;

        public SaveToTxtFileClass() { }

        public SaveToTxtFileClass(string data)
        {
            Data = data;
        }

        public void SetData(string NewData)
        {
            Data = NewData;
        }

        public void SaveToFile(string path)
        {
            using (StreamWriter writer = new StreamWriter(File.Open(path + PATH_EXTENSION, FileMode.Create)))
            {
                writer.Write(Data!.ToString()!);
            }
        }

        public string ReadFromFile(string path)
        {
            using (StreamReader reader = new StreamReader(File.Open(path + PATH_EXTENSION, FileMode.Open)))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
