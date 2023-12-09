using _28.Dishes.AbstractClass;
using _28.Dishes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Dishes.GeorgianCuisine;

class Pelamushi : IDish, GEO
{
    public Pelamushi()
    {
        Ingredients = new()
        {
            "Grape juice",
            "Corn flour"
        };
    }

    public override void Cook()
    {
        Console.WriteLine("""
            Prepare the products. Take the juice from red grapes. It can be either purchased or
            self-cooked. Try the juice before cooking — if it's not too sweet, then you can use
            sugar in the dessert. Flour is suitable for both corn and wheat. You can also take
            their mixture.

            Take a saucepan or a saucepan with a thick bottom. It is important that the dessert
            does not burn when cooking. Read about the subtleties of choosing dishes for
            cooking at the end of the recipe. Pour all the flour into it. Then arm yourself with a
            whisk and, with constant stirring, pour the juice into the flour in portions. Not all at
            once, but in parts — then you will avoid the formation of lumps.

            Put the saucepan with the juice on a low heat. And again, with constant stirring,
            boil the juice and flour mixture until thickened. It is important to stir it all the time,
            as thickening flour can quickly burn. Stirring and a thick bottom will save you from
            this. As soon as large bubbles appear on the surface, turn off the fire. The mass will
            look like a very thick jelly.

            Take suitable forms for serving portions. Pour more hot pelamushi over
            them. Leave the dessert to cool on the table to room temperature, and
            then transfer to the refrigerator until completely stabilized.
            """);
    }

    public override void Service()
    {
        Console.WriteLine("""
            You can serve pelamouches either in the molds in which they were
            cooked, or by turning them over on a plate. When serving, sprinkle the
            dessert with kernels of nuts, walnuts or hazelnuts. Enjoy your meal!
            """);
    }
}