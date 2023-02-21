using System.IO;

namespace Adapter
{
    public class SaveToBinaryFileClassAdapted : SaveToBinaryFileClass, ISaveLoad
    {
        public string Load(string path)
        {
            return base.ReadFromBinFile(path); 
        }

        public void Save(string path)
        {
            base.SaveToBinaryFile(path);
        }
    }
}
