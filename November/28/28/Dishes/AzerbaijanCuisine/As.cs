using _28.Dishes.AbstractClass;
using _28.Dishes.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _28.Dishes.AzerbaijanCuisine;

class As : IDish, AZE
{
    public As()
    {
        Ingredients = new()
        {
            "500 g of meat (lamb or beef), diced",
            "2.5 cups of rice (long-grain rice is best used)",
            "2 onions, cut into thin half rings",
            "3 carrots, cut into strips",
            "1/2 cup butter (preferably Azerbaijani grape seed oil)",
            "1 tsp cinnamon",
            "1 tsp cumin",
            "1 tsp turmeric",
            "Salt to taste",
            "Black pepper to taste",
            "1-2 saffron bunches (pre-soaked in warm water)"
        };
    }

    public override void Cook()
    {
        Console.WriteLine("""
            Preparation of ingredients:

            Cut the meat into small cubes.
            Prepare the onions and carrots for roasting.
            Roasting meat:

            Heat the oil in a deep saucepan or a steamer.
            Fry the meat until golden brown. Stir occasionally.
            Add the onion and fry until transparent.
            Roasting carrots:

            Add the chopped carrots to the meat and onions. Continue frying until the carrots are soft and have a beautiful color.
            Cooking spices:

            Add turmeric, cinnamon, cumin, salt and black pepper. Mix well.
            Cooking rice:

            Rinse the rice in cold water until the water becomes clear.
            Add the rice to a saucepan or pilaf, mix with the meat and vegetables.
            Cooking pilaf:

            Add hot water so that it covers the rice and bring to a boil.
            Reduce the heat, cover the pan with a lid and cook the pilaf over low heat until the rice is ready. It is important that the moisture is completely absorbed.
            Saffron:

            Add saffron bunches soaked in warm water for 10-15 minutes until tender.
            """);
    }

    public override void Service()
    {
        Console.WriteLine("""
            Serve the Azerbaijani pilaf hot, garnished with fresh green herbs or a slice of lemon.

            Azerbaijani pilaf is often served in a special dish called "keze".
            When serving, it can be sprinkled with fried onions and garnished with fresh vegetables.
            """);
    }

}