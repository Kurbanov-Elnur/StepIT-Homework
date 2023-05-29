#include "GraphicCard.h"

graphicCard :: graphicCard(string make, string model, string GPU, string CUDA,
	uint16_t frequency, uint16_t powerConsumption, uint16_t transistors)
{
	this->make = make;
	this->model = model;
	this->GPU = GPU;
	this->CUDA = CUDA;
	*this->frequency = frequency;
	*this->powerConsumption = powerConsumption;
	*this->transistors = transistors;
}

string graphicCard :: getMake()
{
	return make;
}

string graphicCard :: getModel()
{
	return model;
}

string graphicCard :: getGPU()
{
	return GPU;
}

string graphicCard :: getCUDA()
{
	return CUDA;
}

uint16_t graphicCard :: getFrequency()
{
	return *frequency;
}

uint16_t graphicCard :: getPowerConsumption()
{
	return *powerConsumption;
}

uint16_t graphicCard :: getTransistors()
{
	return *transistors;
}

void graphicCard :: pruitnDataGraphicCard() const
{
	cout
		<< "Graphic Card make: " << make << endl
		<< "Graphic Card model: " << model << endl
		<< "Graphic Card GPU: " << GPU << endl
		<< "Graphic Card CUDA: " << CUDA << endl
		<< "Graphic Card frequency: " << *frequency << endl
		<< "Graphic Card power consumption: " << *powerConsumption << endl
		<< "Graphic Card transistors: " << *transistors << endl;
}