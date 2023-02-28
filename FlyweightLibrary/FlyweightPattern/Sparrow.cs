using System;
using System.Windows.Media.Imaging;

namespace FlyweightLibrary
{
    public sealed class Sparrow : Bird
    {
        public Sparrow(): base()
        {
            Uri bitmapUri = new Uri(string.Concat(PATH_TO_FOLDER, "bird11.png"), UriKind.Relative);
            BirdFames[0] = new BitmapImage(bitmapUri);
            bitmapUri = new Uri(string.Concat(PATH_TO_FOLDER, "bird12.png"), UriKind.Relative);
            BirdFames[1] = new BitmapImage(bitmapUri);
            bitmapUri = new Uri(string.Concat(PATH_TO_FOLDER, "bird13.png"), UriKind.Relative);
            BirdFames[2] = new BitmapImage(bitmapUri);
        }
        public override IClonable LightCopy()
        {
            return new Sparrow() { BirdFames = this.BirdFames };
        }
    }
}
