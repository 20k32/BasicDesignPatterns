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
       
        public MainWindow()
        {
            InitializeComponent();
        }

        public void WriteInTextbox(string text)
        {
            EvoTextBox.Text += text;
            EvoTextBox.Text += Environment.NewLine;
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

            if (randomValue == 0)
            {
                randomValue = random.Next(0, 2);
                switch (randomValue)
                {
                    case 0:
                        {
                            humanDecorator = new MaleMechanicDecorator(someHuman);
                            WriteInTextbox(humanDecorator.DoIntelligentWork());
                        } break;
                    case 1:
                        {
                            humanDecorator = new ProgrammerDecorator(someHuman);
                            WriteInTextbox(humanDecorator.DoIntelligentWork());
                        } break;
                }
            }
            else
            {
                randomValue = random.Next(0, 2);
                switch (randomValue)
                {
                    case 0:
                        {
                            humanDecorator = new FemaleTeacherDecorator(someHuman);
                            WriteInTextbox(humanDecorator.DoIntelligentWork());
                        }
                        break;
                    case 1:
                        {
                            humanDecorator = new ProgrammerDecorator(someHuman);
                            WriteInTextbox(humanDecorator.DoIntelligentWork());
                        }
                        break;
                }
            }
            if (tempValue == 0)
            {
                humanDecorator = new MaleAutoProgrammer(someHuman);
                WriteInTextbox(humanDecorator.DoIntelligentWork());
            }
            else
            {
                humanDecorator = new FemaleITTeacher(someHuman);
                WriteInTextbox(humanDecorator.DoIntelligentWork());
            }
        }
    }   
}
