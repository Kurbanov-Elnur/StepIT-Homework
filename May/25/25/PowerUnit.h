#pragma once
#include "Computer.h"

class powerUnit
{
private:
	string make;
	string model;
	uint16_t* power = new uint16_t{};
	uint16_t* tension = new uint16_t{};
	uint16_t* current = new uint16_t{};
	uint16_t* efficiency = new uint16_t{};
public:
	powerUnit(string make, string model, uint16_t power,
		uint16_t tension, uint16_t current, uint16_t efficiency);

	string getMake();
	string getModel();
	uint16_t getPower();
	uint16_t getTension();
	uint16_t getCurrent();
	uint16_t getEfficiency();

	void printDataPowerUnit();
};