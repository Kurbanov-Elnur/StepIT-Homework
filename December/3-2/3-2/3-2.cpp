#include "CarFactory.cpp"



int main()
{

	CarFactory factory;

	Car* car = factory.CreateCar();

	car->DisplayData();
}