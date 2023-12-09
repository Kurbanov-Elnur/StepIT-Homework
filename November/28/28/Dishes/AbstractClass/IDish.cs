using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Dishes.AbstractClass;

abstract class IDish
{
    protected List<string> Ingredients { get; set; }

    public virtual void Cook()
    {
        throw new NotImplementedException();
    }

    public virtual void Service()
    {
        throw new NotImplementedException();
    }

    public void DisplayIngredients()
    {
        Console.WriteLine("Ingredients: ");

        for (int i = 0; i < Ingredients.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Ingredients[i]}");
        }
    }

    public void AddIngredient(string Ingredient)
    {
        Ingredients.Add(Ingredient);
    }

    public void RemoveIngredient(string Ingredient)
    {
        Ingredients.Remove(Ingredient);
    }
}