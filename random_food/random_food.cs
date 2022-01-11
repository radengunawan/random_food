using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_food
{
    class MenuItem
    {

        public static Random pengacak = new Random();
        public string[] Proteins = { "Roast beef", "Salami", "Turkey", "Egg", "Pastrami", "Tofu" };
        public string[] Condiments = { "yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing" };
        public string[] Breads = { "rye", "white", "wheat", "pumpernickel", "a roll" };
        public string Description = "";
        public string Price;


        public void GenerateMenuItem()
        {
            string randomProtein = Proteins[pengacak.Next(Proteins.Length)];
            string randomCondiment = Condiments[pengacak.Next(Condiments.Length)];
            string randomBread = Breads[pengacak.Next(Breads.Length)];
            Description = randomProtein + " with " + randomCondiment + " on " + randomBread;

           //generate random price
            decimal bucks = pengacak.Next(2, 5);
            decimal cents = pengacak.Next(1, 98);
            decimal price = bucks + (cents * .01M);
            Price = price.ToString("c");
        }
    }
}
