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

            // REPLACED BY THIS
            //TextBlock[] item_xaml_list = new TextBlock[] { item1, item2, item3, item4, item5};
            //TextBlock[] price_xaml_list = new TextBlock[] { price1, price2, price3, price4, price5};

            List<TextBlock> item_xaml_list = new List<TextBlock> { item1, item2, item3, item4, item5 };
            List<TextBlock> price_xaml_list = new List<TextBlock> { price1, price2, price3, price4, price5 };

            //string [] item_real_list = new string[item_xaml_list.Length+2];
            List<string> item_real_list = new List<String>();

            //float[] price_real_list = new float[price_xaml_list.Length+2];
            List<float> price_real_list = new List<float>();


            //Order[] list_of_order = new Order[price_xaml_list.Length+2];
            List<Order> list_of_order = new List<Order>();

            float sum = 0;
            // Console.WriteLine(list_of_order.Length);
           

            for (int i = 0; i < item_xaml_list.Count; i++)
            {
                item_xaml_list[i].Text = menuItems[i].Description;
                price_xaml_list[i].Text = menuItems[i].Price;

                //STORE the real back-end (not only visual)
                //IF using ARRAY:
                // item_real_list[i] = menuItems[i].Description;

                //If using list:
                item_real_list.Add(menuItems[i].Description);


                //price_real_list[i] = float.Parse(menuItems[i].Price );
                //IF using ARRAY:
                //price_real_list[i] = 5.50F;
                //If using list:
                price_real_list.Add(float.Parse(menuItems[i].Price.Split('$')[1]));


                // Assembly in a dedicated object is better (more concesiful):
                //if using array:
                //list_of_order[i] = new Order { order_item = menuItems[i].Description, order_price = price_real_list[i] };

                //if using list:
                list_of_order.Add(new Order { order_item = menuItems[i].Description, order_price = price_real_list[i] });
            }
            //Console.WriteLine(list_of_order.Count);



            MenuItem special_the = new MenuItem()
            {
                Proteins = new string[] { "Organic beef", "Mushroom patty", "Mortadella" },
                Breads = new string[] { "a gluten free roll", "a wrap", "pita" },
                Condiments = new string[] { "dijon mustard", "miso dressing", "au jus" }
            };

            special_the.GenerateMenuItem();

            item6.Text = special_the.Description;
            price6.Text = special_the.Price;
            //list_of_order[5] = new Order { order_item = item6.Text, order_price = 5.50F };
            list_of_order.Add(new Order { order_item = item6.Text, order_price = float.Parse(price6.Text.Split('$')[1]) });

            MenuItem guacamole_based = new MenuItem();
            guacamole_based.GenerateMenuItem();

            guacamolePrice = guacamole_based.Price;
            guacamole.Text = "Add guacamole for " + guacamolePrice;
            //list_of_order[6] = new Order { order_item = "guacamole", order_price = 5.50F };
            list_of_order.Add(new Order { order_item = "guacamole", order_price = float.Parse(guacamolePrice.Split('$')[1]) });

            foreach (Order oo in list_of_order)
            {
                //if (oo != null)
               // {
                    sum += oo.order_price;
               // }

            }
            priceTextBox.Text = sum.ToString();
            Console.WriteLine(list_of_order.Count);

          

        }//end MakeTheMenu

        private void Repeat_Btn_Click(object sender, RoutedEventArgs e)
        {
            MakeTheMenu();
        }
    } //end MainWindow
} //end namespace
