#pragma once
#include "Computer.h"



class motherBoard
{
private:
	string make;
	string model;
	CPU* cpu = new CPU{};
public:
	motherBoard(string make, string model, CPU cpu)
	{
		this->make = make;
		this->model = model;
		*this->cpu = cpu;
	}
};