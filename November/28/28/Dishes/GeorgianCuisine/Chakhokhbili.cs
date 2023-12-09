using _28.Dishes.AbstractClass;
using _28.Dishes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Dishes.GeorgianCuisine;

class Chakhokhbili : IDish, GEO
{
    public Chakhokhbili()
    {
        Ingredients = new()
        {
            "Chicken - 1 pc.",
            "Tomatoes - 4 pcs.",
            "Sweet pepper - 2 pcs.",
            "Onion - 4 pcs.",
            "Tomato paste - 2 tbsp. ",
            "Hot pepper - 1 pc.",
            "Garlic - 4 cloves",
            "Adjika (real) - 1 tsp",
            "Utsho-suneli - 0.5 tsp",
            "Ground pepper - to taste",
            "Salt - to taste",
            "Cilantro - 1 bunch",
            "Fresh parsley - 1 bunch",
            "Vegetable oil - for frying"
        };
    }

    public override void Cook()
    {
        Console.WriteLine("""
            Prepare the products.

            Photo of the recipe preparation: Chakhokhbili in Georgian - step No. 2
            Cut the chicken into standard small pieces.

            Photo of the recipe preparation: Chakhokhbili in Georgian - step No. 3
            Put the chicken in a saucepan, add 2 tablespoons of vegetable oil, add a little salt (1 teaspoon). Close the lid and simmer over very low heat for about 20 minutes.

            Photo of the recipe preparation: Chakhokhbili in Georgian - step No. 4
            Cut the onion into half rings. Heat a frying pan, pour 3-4 tablespoons of oil. Lightly fry the onion.

            Photo of the recipe preparation: Chakhokhbili in Georgian - step No.5
            It took 20 minutes for the chicken to stew - pour the fried onion into the pan. Stew the chicken already with onions.

            Photo of the recipe preparation: Chakhokhbili in Georgian - step No. 6
            Chop the tomatoes coarsely.

            Photo of the recipe preparation: Chakhokhbili in Georgian - step No. 7
            Put 2 tablespoons of tomato paste in a frying pan in which the onion was fried and fry it for 1 minute over high heat.

            Photo of the recipe preparation: Chakhokhbili in Georgian - step No.8
            Add the chopped tomatoes to the tomato paste and simmer with it for 2 minutes.

            Photo of the recipe preparation: Chakhokhbili in Georgian - step No. 9
            Add the tomatoes in the tomato sauce to the chicken in a saucepan.

            Photo of the recipe preparation: Chakhokhbili in Georgian - step No.10
            Cut the pepper into strips.

            Photo of the recipe preparation: Chakhokhbili in Georgian - step No.11
            Add to the chicken. Add a little water so that the chicken and vegetables are not completely covered. Bring to a boil.

            Photo of the recipe preparation: Chakhokhbili in Georgian - step No.12
            Add 1 teaspoon of adjika to the pan.

            Photo of the recipe preparation: Chakhokhbili in Georgian - step No. 13
            Wash and chop the parsley and coriander. Add half the herbs and hot pepper to taste. Simmer the chicken and vegetables over low heat for another 20-30 minutes.

            Photo of the recipe preparation: Chakhokhbili in Georgian - step No. 14
            Peel and finely chop the garlic. The readiness of chakhokhbili is determined by chicken meat - it should be strongly boiled, stratified into pieces. Add garlic, remaining herbs, spices and salt.

            Photo of the recipe preparation: Chakhokhbili in Georgian - step No. 15
            Mix everything and close the lid.
            """);
    }

    public override void Service()
    {
        Console.WriteLine("""
            After 10 minutes (the seasonings should work), the chakhokhbili can be served on the table.
            Enjoy your meal.
            """);
    }
}