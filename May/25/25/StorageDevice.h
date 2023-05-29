#pragma once
#include "Computer.h"

class storageDevice
{
private:
	string make{};
	string model{};
	uint16_t* readingSpeed = new uint16_t{};
	uint16_t* writeSpeed = new uint16_t{};
	uint16_t* powerConsumption = new uint16_t{};
	uint16_t* weight = new uint16_t{};
	uint16_t* capacity = new uint16_t{};
public:
	storageDevice(string make, string model, uint16_t readingSpeed, uint16_t writeSpeed
		, uint16_t powerConsumption, uint16_t weight, uint16_t capacity);

	string getMake();
	string getModel();
	uint16_t getReadingSpeed();
	uint16_t getWriteSpeed();
	uint16_t getPowerConsuption();
	uint16_t getWeight();
	uint16_t getCapacity();

	void printDataStorageDevice() const;
};