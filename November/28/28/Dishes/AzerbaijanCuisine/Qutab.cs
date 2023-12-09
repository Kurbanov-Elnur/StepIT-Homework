using _28.Dishes.AbstractClass;
using _28.Dishes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Dishes.AzerbaijanCuisine;

class Qutab : IDish, AZE
{
    public Qutab()
    {
        Ingredients = new()
        {
            "Flour 500 g",
            "Water 1 1/2 Cups",
            "Eggs 1 piece",
            "Salt 1 tsp.q",
            "Beef mince 500 g",
            "Onion 2 pieces",
            "Salt 1 tsp.q",
            "Pepper 1 tsp.q",
            "Pomegranate can be replaced with 1 barberry",
        };
    }

    public override void Cook()
    {
        Console.WriteLine("""
            Add water and salt to the dough and mix..Add as much flour and knead the elastic dough..Dough 10-15 min. should rest

            You passed the meat and onions through a meat grinder. Salt and pepper.

            It is necessary to divide the dough into 8 parts and log..Roll out 0.5 thick and put the filling on one side...sprinkle with pomegranate or barberry and roll up..Fry the
            gutabs on both sides in a hot cast iron skillet..Spread the finished Gutabs in oil and stack them on top of each other..
            """);
    }

    public override void Service()
    {
        Console.WriteLine("""
            Sprinkle with sumax and serve on the table
            """);
    }
}