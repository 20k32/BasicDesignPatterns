using System;
using System.Windows;
using ChainOfResponsibility;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Linq;
using ChainOfResponsibility_Servers;
using System.Globalization;
using System.Windows.Data;

namespace FabricMethodCaffee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public class DoubleToIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double d)
            {
                return (int)Math.Round(d);
            }
            return Binding.DoNothing;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    // чтоб переслать сообщение нужно: текст сообщения, число секунд задерки.
    // чтоб получить сообщение нужно: хранить кэш всех сообщений между пользователями

    // у каждого пользователя будет свой кэш, пользователи загружаються в программу заранее.
    // пользователь может отправить остальным пользователям сообщение, для этого у пользователя должна быть
    // коллекция других пользователей

    public partial class MainWindow : Window
    {
        private List<string> currentUsers = null!;

        public MainWindow()
        {
            currentUsers = new List<string>(new string[] { "Bob", "Rob", "Alex", "All" });
            InitializeComponent();
            UserSelectionBox.SelectedIndex = 0;
        }

        private void UserSelectionBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)((ComboBox)sender).SelectedItem;

            BobPanel.Visibility =
            RobPanel.Visibility =
            AlexPanel.Visibility = Visibility.Hidden;

            SendToBox.Items.Clear();

            foreach (string user in currentUsers.Where(x => !x.Equals(selectedItem.Content.ToString())))
            {
                SendToBox.Items.Add(user);
            }

            SendToBox.SelectedIndex = 0;

            switch (((ComboBox)sender).SelectedIndex)
            {
                case 0:
                    BobPanel.Visibility = Visibility.Visible;
                    break;
                case 1:
                    RobPanel.Visibility = Visibility.Visible;
                    break;
                case 2:
                    AlexPanel.Visibility = Visibility.Visible;
                    break;
            }
        }
    }
}
