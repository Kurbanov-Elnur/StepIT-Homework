using _28.Dishes.AbstractClass;
using _28.Dishes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Dishes.GeorgianCuisine;

class Chvishtari : IDish, GEO
{
    public Chvishtari()
    {
        Ingredients = new()
        {
            "Corn flour 2 Cups",
            "Milk 0.5 Cups (warm)",
            "Sugar 0.5 teaspoons",
            "Salt 0.5 teaspoons",
            "Butter 30 Grams",
            "Suluguni 150-200 Grams",
            "Water To taste (how much dough will take)",
            "Vegetable oil To taste (for frying)"
        };
    }

    public override void Cook()
    {
        Console.WriteLine("""
            Prepare all ingredients.
            Pour the flour into a deep bowl. Add warm milk, salt, sugar and soft butter. Stir and add water.
            Add water in parts as needed. The finished dough should be slightly moist, otherwise it will completely crack when cooking.
            Cut the cheese into oblong cubes. Pinch off a small piece of dough and form a ball.
            Flatten the ball into the shape of a tortilla and place a piece of cheese in the center. Then pinch the edges carefully.
            The shape, as well as the size, can be different.
            Chvishtari can be formed rounded, like cheesecakes, round like donuts or in the shape of boats, like pies.
            Everything will depend on the cheese slicing. I have just the last option in the photo.
            Heat a frying pan with oil and fry the tortillas on both sides until golden brown. 
            """);
    }

    public override void Service()
    {
        Console.WriteLine("""
            Serve ready-made chvishtari to the table hot. Enjoy your meal!
            """);
    }
}