#pragma once
#include "Computer.h"

class RAM
{
private:
	string make{};
	string model{};
	string formFactor{};
	uint16_t* clockFrequency = new uint16_t{};
	uint16_t* throughput = new uint16_t{};
	uint16_t* timings = new uint16_t{};
	uint16_t* volume = new uint16_t{};
public:
	RAM(string make, string model, string formFactor, uint16_t clockFrequency,
		uint16_t throughput, uint16_t timings, uint16_t volume);

	string getMake();
	string getModel();
	string getFormFactor();
	uint16_t getClockFrequency();
	uint16_t getThroughput();
	uint16_t getTimings();
	uint16_t getVolume();

	void printDataRAM();
};