namespace Adapter
{
    public interface ISaveLoad
    {
        string Load(string path);
        void Save(string path);
        void SetData(string data);
    }
}
