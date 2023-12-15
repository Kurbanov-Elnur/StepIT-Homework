#include <iostream>
#include "Car.cpp"
#include <string>

class CarFactory
{
public:

	Car* CreateCar()
	{
		std::string data[5];

		std::cout << "Enter car brend: " << std::endl;
		std::getline(std::cin, data[0]);

		std::cout << "Enter car model: " << std::endl;
		std::getline(std::cin, data[1]);

		std::cout << "Enter car color: " << std::endl;
		std::getline(std::cin, data[2]);

		std::cout << "Enter car owner name: " << std::endl;
		std::getline(std::cin, data[3]);

		std::cout << "Enter car number: " << std::endl;
		std::getline(std::cin, data[4]);

		Car* newCar = new Car(new GeneralCharacteristics(data[0], data[1], data[2]), new UniqueCharacteristics(data[3], data[4]));

		return newCar;
	}
};