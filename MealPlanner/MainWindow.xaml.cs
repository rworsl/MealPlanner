using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows;


namespace MealPlanner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string[]> redMeat = new List<string[]> { };
        List<string[]> whiteMeat = new List<string[]> { };
        List<string[]> veg = new List<string[]> { };
        List<string[]> fish = new List<string[]> { };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void readMealsList()
        {
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\RichW\Desktop\Projects\MealPlanner\MealPlanner\bin\mealplan.txt");
            classifyFood(file);
        }

        private void classifyFood(StreamReader file)
        {
            string line = "";
            while ((line = file.ReadLine()) != null)
            {
                var lineTabs = line.Split('\t');
                if(lineTabs[9] == "Red Meat")
                {
                    redMeat.Add(lineTabs);
                }
                else if (lineTabs[9] == "White Meat")
                {
                    whiteMeat.Add(lineTabs);
                }
                else if (lineTabs[9] == "Fish")
                {
                    fish.Add(lineTabs);
                }
                else if (lineTabs[9] == "Veg")
                {
                    veg.Add(lineTabs);
                }
            }
        }

        /// <summary>
        /// When "run" button is pressed by the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            readMealsList();
        }
    }
}
