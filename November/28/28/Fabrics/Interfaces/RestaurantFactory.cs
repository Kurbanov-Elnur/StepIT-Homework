using _28.Dishes.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Fabrics.AbstractClass;

interface RestaurantFactory
{
    public void Menu();
    public IDish Cook(IDish dish);
    public void Service(IDish dish);
}