using System;
using System.Security.Policy;
using System.Text.Json.Serialization.Metadata;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace FlyweightLibrary
{
    public class BirdFlyingSimulation
    {
        private static Bird sparrow = null!;
        private static Bird duck = null!;
        private static Bird fowl = null!;
        private static Bird swan = null!;

        private Bird[] birds = null!;
        private Random random = null!; 
        public const double IMAGE_WIDTH = 100d;
        public const double IMAGE_HEIGHT = 100d;
        public const int BIAS_COEFF = 500;
        private Canvas Field = null!;
        private ObjectAnimationUsingKeyFrames objAnimation = null!;
        private bool doubleAnimationCompleted = false;
        private bool ObjectAniamtionCompleted = false;

        static BirdFlyingSimulation()
        {
            sparrow = new Sparrow();
            duck = new Duck();
            fowl = new Fowl();
            swan = new Swan();
        }

        public BirdFlyingSimulation(Canvas CurrentField)
        {
            birds = new Bird[10];
            birds[0] = (Sparrow)sparrow.LightCopy();
            birds[1] = (Duck)duck.LightCopy();
            birds[2] = (Fowl)fowl.LightCopy();
            birds[3] = (Swan)swan.LightCopy();
            birds[4] = (Sparrow)sparrow.LightCopy();
            birds[5] = (Duck)duck.LightCopy();
            birds[6] = (Fowl)fowl.LightCopy();
            birds[7] = (Swan)swan.LightCopy();
            birds[8] = (Sparrow)sparrow.LightCopy();
            birds[9] = (Duck)duck.LightCopy();
            random = new Random();
            Field = CurrentField;
        }

        private void ReinitBirds()
        {
            birds[0] = (Sparrow)sparrow.LightCopy();
            birds[1] = (Duck)duck.LightCopy();
            birds[2] = (Fowl)fowl.LightCopy();
            birds[3] = (Swan)swan.LightCopy();
            birds[4] = (Sparrow)sparrow.LightCopy();
            birds[5] = (Duck)duck.LightCopy();
        }

        public double GetImageLeftRigthSpawnPoint(Image image)
        {
            ScaleTransform scaleTransform = null!;
            if (random.Next(0, 2) == 0)
            {
                scaleTransform = new ScaleTransform();
                scaleTransform.ScaleX = -1;
                image.RenderTransform = scaleTransform;
                return Field.Width;
            }
            return 0;
        }

        public double GetImageTopBottomSpawnPoint()
        {
            return random.Next(0, (int)Field.Height - BIAS_COEFF);
        }

        public void ApplyAnimationToCanvas()
        {
            foreach (var item in birds)
            {
                Image image = new Image();
                image.Width = IMAGE_WIDTH;
                image.Height = IMAGE_HEIGHT;
                double lrSpawn = GetImageLeftRigthSpawnPoint(image);
                double tbSpawn = GetImageTopBottomSpawnPoint();
                Canvas.SetLeft(image, lrSpawn);
                Canvas.SetTop(image, tbSpawn);


                Field.Children.Add(image);

                DoubleAnimation doubleAnimation = null!;

                if (lrSpawn == 0)
                {
                    doubleAnimation = MyAnimation.ConfigDoubleAnimation(Field.Width, 0, TimeSpan.FromSeconds(5));
                }
                else
                {
                    doubleAnimation = MyAnimation.ConfigDoubleAnimation(0, Field.Width, TimeSpan.FromSeconds(5));
                }
                doubleAnimation.Completed += OnCompleted;

                ObjectAnimationUsingKeyFrames objAnimation = MyAnimation.ConfigKeyFrameAnimation(TimeSpan.FromSeconds(5), item.BirdFames);
                //objAnimation.Completed += OnCompleted;
                Storyboard storyboard = MyAnimation.ConfigStoryboard(doubleAnimation, objAnimation);
                MyAnimation.ApplyAinmation(doubleAnimation, objAnimation, image);
                storyboard.Begin();
            }
        }
        public void OnCompleted(object sender, EventArgs e)
        {
            Field.Children.Clear();
            ReinitBirds();
            ApplyAnimationToCanvas();
        }

    }
}
