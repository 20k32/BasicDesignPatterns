using System;
using System.Windows;
using CompositeLibrary;
using DecoratorLibrary;

namespace FabricMethodCaffee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        SubmarineComponent rootComponent = null!;
        public const int LIGHT_COMPONENT_WEIGHT = 10;
        public const int MIDDLE_COMPONENT_WEIGHT = 20;
        public const int HEAVY_COMPONENT_WEIGHT = 40;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddSternButton_Click(object sender, RoutedEventArgs e)
        {
            switch (SternComboBox.SelectedIndex)
            {
                case 0:
                    rootComponent = new SubmarineSkeletonComponent("Ligth Stern", LIGHT_COMPONENT_WEIGHT);
                    break;
                case 1:
                    rootComponent = new SubmarineSkeletonComponent("Middle Stern", MIDDLE_COMPONENT_WEIGHT);
                    break;
                case 2:
                    rootComponent = new SubmarineSkeletonComponent("Heavy Stern", HEAVY_COMPONENT_WEIGHT);
                    break;
            }
        }

        private void AddDetailButton_Click(object sender, RoutedEventArgs e)
        {
            if (rootComponent != null)
            {
                switch (EngineComboBox.SelectedIndex)
                {
                    case 0:
                        rootComponent.Add(new SubmarineSkeletonComponent("Ligth Engine", LIGHT_COMPONENT_WEIGHT));
                        break;
                    case 1:
                        rootComponent.Add(new SubmarineSkeletonComponent("Middle Engine", MIDDLE_COMPONENT_WEIGHT));
                        break;
                    case 2:
                        rootComponent.Add(new SubmarineSkeletonComponent("Heavy Engine", HEAVY_COMPONENT_WEIGHT));
                        break;
                }

                switch (MotorComboBox.SelectedIndex)
                {
                    case 0:
                        rootComponent.Add(new SubmarineSkeletonComponent("Ligth Motor", LIGHT_COMPONENT_WEIGHT));
                        break;
                    case 1:
                        rootComponent.Add(new SubmarineSkeletonComponent("Middle Motor", MIDDLE_COMPONENT_WEIGHT));
                        break;
                    case 2:
                        rootComponent.Add(new SubmarineSkeletonComponent("Heavy Motor", HEAVY_COMPONENT_WEIGHT));
                        break;
                }

                switch (NavigationSysComboBox.SelectedIndex)
                {
                    case 0:
                        rootComponent.Add(new SubmarineSkeletonComponent("Ligth Navigation System", LIGHT_COMPONENT_WEIGHT));
                        break;
                    case 1:
                        rootComponent.Add(new SubmarineSkeletonComponent("Middle Navigation System", MIDDLE_COMPONENT_WEIGHT));
                        break;
                    case 2:
                        rootComponent.Add(new SubmarineSkeletonComponent("Heavy Navigation System", HEAVY_COMPONENT_WEIGHT));
                        break;
                }

                if (AverageCheckBox.IsChecked == true)
                {
                    rootComponent.Add(new SubmarineSternComponent("Average Rocket System", LIGHT_COMPONENT_WEIGHT));
                }
                if (AdvancedCheckBox.IsChecked == true)
                {
                    rootComponent.Add(new SubmarineSternComponent("Advanced Rocket System", MIDDLE_COMPONENT_WEIGHT));
                }
                if (ExtendedCheckBox.IsChecked == true)
                {
                    rootComponent.Add(new SubmarineSternComponent("Extended Rocket System", HEAVY_COMPONENT_WEIGHT));
                }
            }
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            if (rootComponent != null)
            {
                foreach (SubmarineComponent item in rootComponent.GetChildren())
                {
                    SubmarineTextBox.Text += string.Concat(item.Name, " = ", item.Weight);
                    SubmarineTextBox.Text += Environment.NewLine;
                }
            }

        }
    }
}
