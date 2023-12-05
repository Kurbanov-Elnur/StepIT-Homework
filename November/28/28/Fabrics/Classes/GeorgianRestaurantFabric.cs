using _28.Dishes.Interfaces;
using _28.Fabrics.AbstractClass;
using _28.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Fabrics.Classes;

class GeorgianRestaurantFabric : DishFactory
{
    public override IAppetizer CreateAppetizer()
    {
        throw new NotImplementedException();
    }

    public override IDessert CreateDesert()
    {
        throw new NotImplementedException();
    }

    public override IMainCourse CreateMainCourse()
    {
        throw new NotImplementedException();
    }
}