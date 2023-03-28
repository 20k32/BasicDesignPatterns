using System;
using System.Windows;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Linq;
using System.Globalization;
using System.Windows.Data;
using Observer;

namespace FabricMethodCaffee
{
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

    // todo: реализовать задержку для асинхронности!!!

    // чтоб переслать сообщение нужно: текст сообщения, число секунд задерки.
    // чтоб получить сообщение нужно: хранить кэш всех сообщений между пользователями

    // у каждого пользователя будет свой кэш, пользователи загружаються в программу заранее.
    // пользователь может отправить остальным пользователям сообщение, для этого у пользователя должна быть
    // коллекция других пользователей

    public partial class MainWindow : Window
    {
        private TextBox currentTextBox = null!;

        private IObserver Bob;
        private IObserver Rob;
        private IObserver Alex;
        private IObserver temp = null!;

        private IObservable Correspondence;

        private List<string> currentUsers = null!;

        public MainWindow()
        {
            currentUsers = new List<string>(new string[] { nameof(Bob), nameof(Rob), nameof(Alex), "All" });

            Bob = new User(currentUsers[0]);
            Rob = new User(currentUsers[1]);
            Alex = new User(currentUsers[2]);

            Correspondence = new Chat();
            Correspondence.AddObserver(Bob);
            Correspondence.AddObserver(Rob);
            Correspondence.AddObserver(Alex);

            InitializeComponent();
            UserSelectionBox.SelectedIndex = 0;
        }

        private void UserSelectionBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)((ComboBox)sender).SelectedItem;
            TextBox tempChatTextBox = null!;

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
                    {
                        BobPanel.Visibility = Visibility.Visible;
                        currentTextBox = BobTextBox;
                        tempChatTextBox = BobChatTextBox;
                        temp = Bob;
                    }
                    break;
                case 1:
                    {
                        RobPanel.Visibility = Visibility.Visible;
                        currentTextBox = RobTextBox;
                        tempChatTextBox = RobChatTextBox;
                        temp = Rob;
                    }    
                    break;
                case 2:
                    {
                        AlexPanel.Visibility = Visibility.Visible;
                        currentTextBox = AlexTextBox;
                        tempChatTextBox = AlexChatTextBox;
                        temp = Alex;
                    }
                    break;
            }

            tempChatTextBox.Clear();
            Correspondence.SetObserverThatNotifies(temp);

            foreach (string item in ((IAccessCache)temp).GetCache())
            {
                tempChatTextBox.Text += item;
                tempChatTextBox.Text += Environment.NewLine;
            }
        }

        private void SendButtonSync_Click(object sender, RoutedEventArgs e)
        {
            if (currentTextBox.Text.Trim() == string.Empty)
            {
                return;
            }

            if (SendToBox.SelectedIndex != SendToBox.Items.Count - 1)
            {
                switch (SendToBox.SelectedValue)
                {
                    case "Bob":
                        {
                            Correspondence.NotifyObserver(Bob, currentTextBox.Text);
                        }
                        break;
                    case "Rob":
                        {
                            Correspondence.NotifyObserver(Rob, currentTextBox.Text);
                        }
                        break;
                    case "Alex":
                        {
                            Correspondence.NotifyObserver(Alex, currentTextBox.Text);
                        }
                        break;
                }
            }
            else
            {
                Correspondence.NotifyObservers(currentTextBox.Text);
            }
            currentTextBox.Text = string.Empty;
        }
    }
}
