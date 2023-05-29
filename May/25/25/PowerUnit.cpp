#include "PowerUnit.h"

powerUnit :: powerUnit(string make, string model, uint16_t power,
	uint16_t tension, uint16_t current, uint16_t efficiency)
{
	this->make = make;
	this->model = model;
	*this->power = power;
	*this->tension = tension;
	*this->current = current;
	*this->efficiency = efficiency;
}

string powerUnit :: getMake()
{
	return make;
}

string powerUnit :: getModel()
{
	return model;
}
uint16_t powerUnit :: getPower()
{
	return *power;
}

uint16_t powerUnit :: getTension()
{
	return *tension;
}

uint16_t powerUnit :: getCurrent()
{
	return *current;
}

uint16_t powerUnit :: getEfficiency()
{
	return *efficiency;
}

void powerUnit :: printDataPowerUnit()
{
	cout
		<< "Power Unit make: " << make << endl
		<< "Power Unit model: " << model << endl
		<< "Power Unit power: " << *power << endl
		<< "Power Unit tension: " << *tension << endl
		<< "Power Unit current: " << *current << endl
		<< "Power Unit efficiency: " << *efficiency << endl;
}