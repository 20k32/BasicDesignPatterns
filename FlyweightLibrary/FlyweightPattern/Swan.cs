using System;
using System.Windows.Media.Imaging;

namespace FlyweightLibrary
{
    public class Swan : Bird
    {
        public Swan() : base()
        {
            Uri bitmapUri = new Uri(string.Concat(PATH_TO_FOLDER, "bird41.png"), UriKind.Relative);
            BirdFames[0] = new BitmapImage(bitmapUri);
            bitmapUri = new Uri(string.Concat(PATH_TO_FOLDER, "bird42.png"), UriKind.Relative);
            BirdFames[1] = new BitmapImage(bitmapUri);
            bitmapUri = new Uri(string.Concat(PATH_TO_FOLDER, "bird43.png"), UriKind.Relative);
            BirdFames[2] = new BitmapImage(bitmapUri);
        }
        public override IClonable LightCopy()
        {
            return new Swan() { BirdFames = this.BirdFames };
        }
    }
}
