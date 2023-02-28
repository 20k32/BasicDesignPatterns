using System.CodeDom;
using System.Windows.Media.Imaging;

namespace FlyweightLibrary
{
    public interface IClonable
    {
        IClonable LightCopy();
    }

    public abstract class Bird : IClonable
    {
        public const int BIRD_FRAMES = 3;
        public const string PATH_TO_FOLDER = "..\\..\\..\\Images\\";

        public BitmapImage[] BirdFames { get; protected set; }

        public Bird()
        {
            BirdFames = new BitmapImage[BIRD_FRAMES];
        }

        public abstract IClonable LightCopy();
    }
}
