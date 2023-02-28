using System;
using System.Windows.Media.Imaging;

namespace FlyweightLibrary
{
    public class Fowl : Bird
    {
        public Fowl() : base()
        {
            Uri bitmapUri = new Uri(string.Concat(PATH_TO_FOLDER, "bird31.png"), UriKind.Relative);
            BirdFames[0] = new BitmapImage(bitmapUri);
            bitmapUri = new Uri(string.Concat(PATH_TO_FOLDER, "bird32.png"), UriKind.Relative);
            BirdFames[1] = new BitmapImage(bitmapUri);
            bitmapUri = new Uri(string.Concat(PATH_TO_FOLDER, "bird33.png"), UriKind.Relative);
            BirdFames[2] = new BitmapImage(bitmapUri);
        }

        public override IClonable LightCopy()
        {
            return new Fowl() { BirdFames = this.BirdFames };
        }
    }
}
