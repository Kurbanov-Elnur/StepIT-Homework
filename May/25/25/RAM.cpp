#include "RAM.h"

RAM :: RAM(string make, string model, string formFactor, uint16_t clockFrequency,
	uint16_t throughput, uint16_t timings, uint16_t volume)
{
	this->make = make;
	this->model = model;
	this->formFactor = formFactor;
	*this->clockFrequency = clockFrequency;
	*this->throughput = throughput;
	*this->timings = timings;
	*this->volume = volume;
}

string RAM :: getMake()
{
	return make;
}

string RAM :: getModel()
{
	return model;
}

string RAM :: getFormFactor()
{
	return formFactor;
}

uint16_t RAM :: getClockFrequency()
{
	return *clockFrequency;
}

uint16_t RAM :: getThroughput()
{
	return *throughput;
}

uint16_t RAM :: getTimings()
{
	return *timings;
}

uint16_t RAM :: getVolume()
{
	return *volume;
}

void RAM :: printDataRAM()
{
	cout
		<< "RAM make: " << make << endl
		<< "RAM model: " << model << endl
		<< "RAM form factor: " << formFactor << endl
		<< "RAM clock frequency: " << *clockFrequency << endl
		<< "RAM throughput: " << *throughput << endl
		<< "RAM timings: " << *timings << endl
		<< "RAM volume: " << *volume << endl;
}