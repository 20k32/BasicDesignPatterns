using System;
using System.Windows;
using DecoratorLibrary;

namespace FabricMethodCaffee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        private int counter = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void WriteInTextbox(string text)
        {

            EvoTextBox.Text += (++counter).ToString() + ". " + text;
            EvoTextBox.Text += Environment.NewLine;
            counter = counter == 6 ? 0 : counter; 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EvoTextBox.Clear();

            Human someHuman = null!;
            AbstractEvolutionDecorator humanDecorator = null!;

            Random random = new Random();
            int randomValue = random.Next(0, 2);
            int tempValue = randomValue;
            if (randomValue == 0)
            {
                someHuman = new Male();
            }
            else
            {
                someHuman = new Female();
            }

            WriteInTextbox(someHuman.DoWork());

            if (randomValue == 0) // male
            {
                randomValue = random.Next(0, 2);
                switch (randomValue)
                {
                    case 0:
                        {
                            humanDecorator = new MaleHouseBuilderDecorator(someHuman);
                        } break;
                    case 1:
                        {
                            humanDecorator = new HouseholdDecorator(someHuman);
                            
                        } break;
                }
                WriteInTextbox(humanDecorator.DoIntelligentWork());
            }
            else // female
            {
                randomValue = random.Next(0, 2);
                switch (randomValue)
                {
                    case 0:
                        {
                            humanDecorator = new FemaleHousekeepingDecorator(someHuman);
                        }
                        break;
                    case 1:
                        {
                            humanDecorator = new HouseholdDecorator(someHuman);
                        }
                        break;
                }
                WriteInTextbox(humanDecorator.DoIntelligentWork());
            }
            if (tempValue == 0)
            {
                humanDecorator = new MaleDeveloperDecorator(someHuman);
                WriteInTextbox(humanDecorator.DoIntelligentWork());
                randomValue = random.Next(0, 2);
                switch (randomValue)
                {
                    case 0:
                        {
                            humanDecorator = new MaleEngineerDecorator(someHuman);
                        }
                        break;
                    case 1:
                        {
                            humanDecorator = new AstronautDecorator(someHuman);
                        }
                        break;
                }
                WriteInTextbox(humanDecorator.DoIntelligentWork());

            }
            else
            {
                humanDecorator = new FemalePrinterDecorator(someHuman);
                WriteInTextbox(humanDecorator.DoIntelligentWork());
                randomValue = random.Next(0, 2);
                switch (randomValue)
                {
                    case 0:
                        {
                            humanDecorator = new FemaleCalculatorDecorator(someHuman);
                        }
                        break;
                    case 1:
                        {
                            humanDecorator = new AstronautDecorator(someHuman);
                        }
                        break;
                }
                WriteInTextbox(humanDecorator.DoIntelligentWork());
            }
            if (tempValue == 0)
            {
                randomValue = random.Next(0, 2);
                switch (randomValue)
                {
                    case 0:
                        {
                            humanDecorator = new MaleMechanicDecorator(someHuman);
                        }
                        break;
                    case 1:
                        {
                            humanDecorator = new ProgrammerDecorator(someHuman);
                        }
                        break;
                }
                WriteInTextbox(humanDecorator.DoIntelligentWork());

            }
            else
            {
                randomValue = random.Next(0, 2);
                switch (randomValue)
                {
                    case 0:
                        {
                            humanDecorator = new FemaleTeacherDecorator(someHuman);
                        }
                        break;
                    case 1:
                        {
                            humanDecorator = new ProgrammerDecorator(someHuman);
                        }
                        break;
                }
                WriteInTextbox(humanDecorator.DoIntelligentWork());
            }
            if (tempValue == 0)
            {
                humanDecorator = new MaleAutoProgrammer(someHuman);
            }
            else
            {
                humanDecorator = new FemaleITTeacher(someHuman);
            }
            WriteInTextbox(humanDecorator.DoIntelligentWork());
        }
    }   
}
