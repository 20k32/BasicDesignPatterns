using System;
using System.Windows.Media.Imaging;

namespace FlyweightLibrary
{
    public class Duck : Bird
    {
        public Duck() : base()
        {
            Uri bitmapUri = new Uri(string.Concat(PATH_TO_FOLDER, "bird21.png"), UriKind.Relative);
            BirdFames[0] = new BitmapImage(bitmapUri);
            bitmapUri = new Uri(string.Concat(PATH_TO_FOLDER, "bird22.png"), UriKind.Relative);
            BirdFames[1] = new BitmapImage(bitmapUri);
            bitmapUri = new Uri(string.Concat(PATH_TO_FOLDER, "bird23.png"), UriKind.Relative);
            BirdFames[2] = new BitmapImage(bitmapUri);
        }

        public override IClonable LightCopy()
        {
            return new Duck() { BirdFames = this.BirdFames };
        }
    }
}
