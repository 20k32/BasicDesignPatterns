namespace Adapter
{
    public class SaveToXmlFileClassAdapted : SaveToXmlFileClass, ISaveLoad
    {
        public string Load(string path)
        {
            return base.Open(path);
        }

        public void Save(string path)
        {
            base.Create(path);
        }
    }
}
