namespace Observer
{
    public interface IObserver
    {
        string Name { get; set; }
        void Update(string Information);
    }
}
