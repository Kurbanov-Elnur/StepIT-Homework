using _28.Dishes.AbstractClass;
using _28.Dishes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Dishes.AzerbaijanCuisine;

class Bamiya : IDish, AZE
{
    public Bamiya()
    {
        Ingredients = new()
        {
            "500 g flour",
            "200 g powdered sugar",
            "1 egg",
            "100 g vegetable oil",
            "half Ch.q. soda",
            "1 pinch of salt"
        };
    }

    public override void Cook()
    {
        Console.WriteLine("""
            First, we add tea soda and boiling water to the flour and knead the dough.
            Then we cooland add eggs to it. We pass the dough through a meat grinder. 
            But a metal plate with small teeth measuring 0.17 mm in diameter is placed in the middle of the knife place of the meat grinder.
            The Burmese dough from the meat grinder is divided into equal parts 8 cm long.
            Bami is fried in vegetable oil, dipped in sugar syrup.
            """);
    }

    public override void Service()
    {
        Console.WriteLine("""
            After applying the syrup to the soul, it is sprinkled with sugar powder on top and served.
            """);
    }
}