#include "CPU.h"

CPU :: CPU(string make, string model, string frequency, string performance, string socket)
{
	this->make = make;
	this->model = model;
	this->frequency = frequency;
	this->performance = performance;
	this->socket = socket;
}

string CPU :: getMake()
{
	return make;
}

string CPU :: getModel()
{
	return model;
}

string CPU :: getFrequency()
{
	return frequency;
}

string CPU :: getPerformance()
{
	return performance;
}

string CPU :: getSocket()
{
	return socket;
}

void CPU :: printDataCPU() const
{
	cout
		<< "CPU make: " << make << endl
		<< "CPU model: " << model << endl
		<< "CPU frequency: " << frequency << endl
		<< "CPU performance: " << performance << endl
		<< "CPU socket: " << socket << endl;
}