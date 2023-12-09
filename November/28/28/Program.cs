using _28.Dishes.AzerbaijanCuisine;
using _28.Dishes.GeorgianCuisine;
using _28.Fabrics.AbstractClass;
using _28.Fabrics.Classes;

RestaurantFactory fac = new AzerbaijanRestaurantFactory();


fac.Menu();

fac = new GeorgianRestaurantFabric();

fac.Menu();