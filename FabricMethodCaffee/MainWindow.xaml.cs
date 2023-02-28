using System.Threading.Tasks;
using System.Windows;
using Adapter;
using ArrayListAdapter;
using System;
using System.Linq;
using System.Collections.Generic;
using FlyweightLibrary;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Threading;
using System.Windows.Media.Animation;
//using Adapter;


namespace FabricMethodCaffee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    // 1000 h 1400 w
    public partial class MainWindow : Window
    {
       // BitmapImage[] frames;
        public MainWindow()
        {
            InitializeComponent();

            /* frames = new BitmapImage[3];
             frames[0] = new BitmapImage(new Uri("..\\..\\..\\Images\\bird41.png", UriKind.Relative));
             frames[1] = new BitmapImage(new Uri("..\\..\\..\\Images\\bird42.png", UriKind.Relative));
             frames[2] = new BitmapImage(new Uri("..\\..\\..\\Images\\bird43.png", UriKind.Relative));

             ScaleTransform scaleTransform = new ScaleTransform();
             scaleTransform.ScaleX = -1;


             // Создаем картинку и добавляем ее в канвас
             Image image = new Image();
             image.Name = "image";
             image.Width = 100;
             image.Height = 100;
             Canvas.SetLeft(image, 0);
             Canvas.SetTop(image, 0);
             image.RenderTransform = scaleTransform;
             MainField.Children.Add(image);
             ImageBrush backgroundBrush = new ImageBrush();
             backgroundBrush.ImageSource = new BitmapImage(new Uri("..\\..\\..\\Images\\Background.jpg", UriKind.Relative));
             MainField.Background = backgroundBrush;

             // Создаем анимацию сдвига картинки вправо
             DoubleAnimation animation = new DoubleAnimation();
             animation.From = 0;
             animation.To = 1600;
             animation.Duration = new Duration(TimeSpan.FromSeconds(5));
             //animation.RepeatBehavior = RepeatBehavior.Forever;
             // Создаем анимацию смены изображения в процессе анимации
             ObjectAnimationUsingKeyFrames imageAnimation = new ObjectAnimationUsingKeyFrames();
             imageAnimation.BeginTime = TimeSpan.FromSeconds(0);
             imageAnimation.Duration = TimeSpan.FromSeconds(0.5);
             imageAnimation.RepeatBehavior = RepeatBehavior.Forever;

             // Создаем KeyFrames с разными изображениями
             DiscreteObjectKeyFrame keyFrame1 = new DiscreteObjectKeyFrame();
             keyFrame1.KeyTime = KeyTime.FromPercent(0.0);
             keyFrame1.Value = frames[1];

             DiscreteObjectKeyFrame keyFrame2 = new DiscreteObjectKeyFrame();
             keyFrame2.KeyTime = KeyTime.FromPercent(0.3);
             keyFrame2.Value = frames[2];

             DiscreteObjectKeyFrame keyFrame3 = new DiscreteObjectKeyFrame();
             keyFrame3.KeyTime = KeyTime.FromPercent(0.6);
             keyFrame3.Value = frames[0];

             imageAnimation.KeyFrames.Add(keyFrame1);
             imageAnimation.KeyFrames.Add(keyFrame2);
             imageAnimation.KeyFrames.Add(keyFrame3);

             // Добавляем анимации в Storyboard
             Storyboard storyboard = new Storyboard();
             storyboard.Children.Add(animation);
             storyboard.Children.Add(imageAnimation);

             // Указываем объекты, которые будут анимироваться
             Storyboard.SetTarget(animation, image);
             Storyboard.SetTargetProperty(animation, new PropertyPath(Canvas.LeftProperty));
             Storyboard.SetTarget(imageAnimation, image);
             Storyboard.SetTargetProperty(imageAnimation, new PropertyPath(Image.SourceProperty));

             // Запускаем Storyboard
             storyboard.Begin(image);*/


            ImageBrush backgroundBrush = new ImageBrush();
            backgroundBrush.ImageSource = new BitmapImage(new Uri("..\\..\\..\\Images\\Background.jpg", UriKind.Relative));
            MainField.Background = backgroundBrush;
            MainField.Width = 1400;
            MainField.Height = 1000;

            BirdFlyingSimulation simulation = new BirdFlyingSimulation(MainField);
            simulation.ApplyAnimationToCanvas();

        }
    }   
}
