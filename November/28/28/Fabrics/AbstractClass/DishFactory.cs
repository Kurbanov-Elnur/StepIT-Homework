using _28.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Fabrics.AbstractClass;

abstract class DishFactory
{
    public abstract IMainCourse CreateMainCourse();
    public abstract IAppetizer CreateAppetizer();
    public abstract IDessert CreateDesert();
}