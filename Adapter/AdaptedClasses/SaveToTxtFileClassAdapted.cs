namespace Adapter
{
    public class SaveToTxtFileClassAdapted : SaveToTxtFileClass, ISaveLoad
    {
        public string Load(string path)
        {
            return base.ReadFromFile(path);
        }

        public void Save(string path)
        {
            base.SaveToFile(path);
        }
    }
}
