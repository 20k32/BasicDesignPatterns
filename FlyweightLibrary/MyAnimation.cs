using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace FlyweightLibrary
{
    public static class MyAnimation
    {

        public static ObjectAnimationUsingKeyFrames ConfigKeyFrameAnimation(TimeSpan Duration, params BitmapImage[] frames)
        {
            // Создаем анимацию смены изображения в процессе анимации
            ObjectAnimationUsingKeyFrames imageAnimation = new ObjectAnimationUsingKeyFrames();
            imageAnimation.BeginTime = TimeSpan.FromSeconds(0);
            imageAnimation.Duration = Duration;

            // Создаем KeyFrames с разными изображениями
            DiscreteObjectKeyFrame keyFrame1 = new DiscreteObjectKeyFrame();
            keyFrame1.KeyTime = KeyTime.FromPercent(0.0);
            keyFrame1.Value = frames[0];

            DiscreteObjectKeyFrame keyFrame2 = new DiscreteObjectKeyFrame();
            keyFrame2.KeyTime = KeyTime.FromPercent(0.3);
            keyFrame2.Value = frames[1];

            DiscreteObjectKeyFrame keyFrame3 = new DiscreteObjectKeyFrame();
            keyFrame3.KeyTime = KeyTime.FromPercent(0.6);
            keyFrame3.Value = frames[2];

            imageAnimation.KeyFrames.Add(keyFrame1);
            imageAnimation.KeyFrames.Add(keyFrame2);
            imageAnimation.KeyFrames.Add(keyFrame3);

            return imageAnimation;
        }

        public static DoubleAnimation ConfigDoubleAnimation(double from, double to, TimeSpan DurationSeconds)
        {
            // Создаем анимацию сдвига картинки вправо
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = from;
            animation.To = to;
            animation.Duration = new Duration(DurationSeconds);
            return animation;
        }

        public static Storyboard ConfigStoryboard(DoubleAnimation animation, ObjectAnimationUsingKeyFrames imageAnimation)
        {
            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(imageAnimation);
            storyboard.Children.Add(animation);
            
            return storyboard;
            // Запускаем Storyboard
            //storyboard.Begin(image);
        }
        public static void ApplyAinmation(DoubleAnimation animation, ObjectAnimationUsingKeyFrames imageAnimation, Image image)
        {
            // Указываем объекты, которые будут анимироваться
            Storyboard.SetTarget(animation, image);
            Storyboard.SetTargetProperty(animation, new PropertyPath(Canvas.LeftProperty));
            Storyboard.SetTarget(imageAnimation, image);
            Storyboard.SetTargetProperty(imageAnimation, new PropertyPath(Image.SourceProperty));
        }

        
    }
}
