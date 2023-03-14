using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
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
        SubmarineComponent subrootDeckComponent = null!;

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
            subrootDeckComponent = new SubmarineSkeletonComponent(" Deck", LIGHT_COMPONENT_WEIGHT + MIDDLE_COMPONENT_WEIGHT + HEAVY_COMPONENT_WEIGHT);
        }

        private void AddDetailButton_Click(object sender, RoutedEventArgs e)
        {
            SubmarineTextBox.Clear();

            SubmarineComponent[] childrens = rootComponent.GetChildren().ToArray();
            if (childrens.Length > 0)
            {
                foreach (SubmarineComponent item in childrens)
                {
                    if (item is SubmarineSkeletonComponent subroot)
                    {
                        SubmarineComponent[] subChildrens = subroot.GetChildren().ToArray();
                        if (subChildrens.Length > 0)
                        {
                            foreach (SubmarineComponent subItem in subChildrens)
                            {
                                subroot.Remove(subItem);
                            }
                        }
                    }
                    rootComponent.Remove(item);

                }
            }

           

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

                if (AverageCheckBox.IsChecked == true)
                {
                    rootComponent.Add(new SubmarineSkeletonComponent("Average Rocket System", LIGHT_COMPONENT_WEIGHT));
                }
                if (AdvancedCheckBox.IsChecked == true)
                {
                    rootComponent.Add(new SubmarineSkeletonComponent("Advanced Rocket System", MIDDLE_COMPONENT_WEIGHT));
                }
                if (ExtendedCheckBox.IsChecked == true)
                {
                    rootComponent.Add(new SubmarineSkeletonComponent("Extended Rocket System", HEAVY_COMPONENT_WEIGHT));
                }

                if (RearPropellerCheckBox.IsChecked == true)
                {
                    subrootDeckComponent.Add(new SubmarineSkeletonComponent("Rear Propeller", MIDDLE_COMPONENT_WEIGHT));
                }
                if (PowerPlantCheckBox.IsChecked == true)
                {
                    subrootDeckComponent.Add(new SubmarineSkeletonComponent("Power Plant", MIDDLE_COMPONENT_WEIGHT));
                }
                if (CompressedAirBottleCheckBox.IsChecked == true)
                {
                    subrootDeckComponent.Add(new SubmarineSkeletonComponent("Compressed air bottle", MIDDLE_COMPONENT_WEIGHT));
                }

                if (AdditionalCrewCheckBox.IsChecked == true)
                {
                    subrootDeckComponent.Add(new SubmarineSkeletonComponent("Additional Crew", MIDDLE_COMPONENT_WEIGHT));
                }
                if (AdditionalRepairmentCheckBox.IsChecked == true)
                {
                    subrootDeckComponent.Add(new SubmarineSkeletonComponent("Additional Repairmen", LIGHT_COMPONENT_WEIGHT));
                }
                if (AdditionalCommanderCheckBox.IsChecked == true)
                {
                    subrootDeckComponent.Add(new SubmarineSkeletonComponent("Additional Commander", LIGHT_COMPONENT_WEIGHT));
                }

                SubmarineComponent[] subrootComponents = subrootDeckComponent.GetChildren().ToArray();
                if (subrootComponents.Length != 0)
                {
                    rootComponent.Add(subrootDeckComponent);
                }

                switch (NavigationSysComboBox.SelectedIndex)
                {
                    case 0:
                        rootComponent.Add(new SubmarineSternComponent("Ligth Navigation System", LIGHT_COMPONENT_WEIGHT));
                        break;
                    case 1:
                        rootComponent.Add(new SubmarineSternComponent("Middle Navigation System", MIDDLE_COMPONENT_WEIGHT));
                        break;
                    case 2:
                        rootComponent.Add(new SubmarineSternComponent("Heavy Navigation System", HEAVY_COMPONENT_WEIGHT));
                        break;
                }
            }
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            if (rootComponent != null)
            {
                SubmarineTextBox.Text += string.Concat(rootComponent.Name, " = ", rootComponent.Weight);
                SubmarineTextBox.Text += Environment.NewLine;
                foreach (SubmarineComponent item in rootComponent.GetChildren())
                {
                    SubmarineTextBox.Text += string.Concat(item.Name, " = ", item.Weight);
                    SubmarineTextBox.Text += Environment.NewLine;
                    if (item is SubmarineSkeletonComponent subroot)
                    {
                        foreach (SubmarineComponent subItem in subroot.GetChildren())
                        {
                            SubmarineTextBox.Text += string.Concat("    ", subItem.Name, " = ", subItem.Weight);
                            SubmarineTextBox.Text += Environment.NewLine;
                        }
                    }
                }
            }

        }
    }
}
