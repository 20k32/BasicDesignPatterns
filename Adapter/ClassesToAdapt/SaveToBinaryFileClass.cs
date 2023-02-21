using System.IO;

namespace Adapter
{
    public class SaveToBinaryFileClass
    {
        private const string PATH_EXTENSION = ".bin";
        private string Data { get; set; } = null!;

        public SaveToBinaryFileClass() { }

        public SaveToBinaryFileClass(string data)
        {
            Data = data;
        }

        public void SetData(string NewData)
        {
            Data = NewData;
        }

        public void SaveToBinaryFile(string path)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(path + PATH_EXTENSION, FileMode.Create)))
            {
                writer.Write(Data!.ToString()!);
            }
        }

        public string ReadFromBinFile(string path)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(path + PATH_EXTENSION, FileMode.Open)))
            {
                string result = string.Empty;

                while (reader.PeekChar() > -1)
                {
                    result += reader.ReadString();
                }

                return result;
            }
        }
    }
}
