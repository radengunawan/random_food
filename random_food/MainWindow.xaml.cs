using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace random_food
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeTheMenu();
        } //end main window



        private void MakeTheMenu()
        {
            MenuItem[] menuItems = new MenuItem[5];
            string guacamolePrice;

            for (int i = 0; i < 5; i++)
            {
                menuItems[i] = new MenuItem();

                if (i >= 3) {

                    menuItems[i].Breads = new string[] { "plain bagel", "onion bagel", "pumpernickel bagel", "everything bagel" };

                } //end if

                menuItems[i].GenerateMenuItem();

            } //end loop

            //Relationship between XAML - .CS 

            //string[] item = new string[] { item1.Text, item2.Text , item3.Text, item4.Text, item5.Text };
            //string[]


            item1.Text = menuItems[0].Description;
            price1.Text = menuItems[0].Price;

            item2.Text = menuItems[1].Description;
            price2.Text = menuItems[1].Price;

            item3.Text = menuItems[2].Description;
            price3.Text = menuItems[2].Price;

            item4.Text = menuItems[3].Description;
            price4.Text = menuItems[3].Price;

            item5.Text = menuItems[4].Description;
            price5.Text = menuItems[4].Price;

            MenuItem special_the = new MenuItem()
            {
                Proteins = new string[] { "Organic beef", "Mushroom patty", "Mortadella" },
                Breads = new string[] { "a gluten free roll", "a wrap", "pita" },
                Condiments = new string[] { "dijon mustard", "miso dressing", "au jus" }
            };

            special_the.GenerateMenuItem();

            item6.Text = special_the.Description;
            price6.Text = special_the.Price;

            MenuItem guacamole_based = new MenuItem();
            guacamole_based.GenerateMenuItem();

            guacamolePrice = guacamole_based.Price;
            guacamole.Text = "Add guacamole for " + guacamolePrice;
        }//end MakeTheMenu

        private void Repeat_Btn_Click(object sender, RoutedEventArgs e)
        {
            MakeTheMenu();
        }
    } //end MainWindow
} //end namespace
