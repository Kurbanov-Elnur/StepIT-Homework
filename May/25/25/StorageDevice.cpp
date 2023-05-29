#include "StorageDevice.h"


storageDevice :: storageDevice(string make, string model, uint16_t readingSpeed, uint16_t writeSpeed
		, uint16_t powerConsumption, uint16_t weight, uint16_t capacity)
{
	this->make = make;
	this->model = model;	
	*this->readingSpeed = readingSpeed;
	*this->writeSpeed = writeSpeed;
	*this->powerConsumption = powerConsumption;
	*this->weight = weight;
	*this->capacity = capacity;
}

string storageDevice :: getMake()
{
	return make;
}

string storageDevice :: getModel()
{
	return model;
}

uint16_t storageDevice :: getReadingSpeed()
{
	return *readingSpeed;
}

uint16_t storageDevice :: getWriteSpeed()
{
	return *writeSpeed;
}

uint16_t storageDevice :: getPowerConsuption()
{
	return *powerConsumption;
}

uint16_t storageDevice :: getWeight()
{
	return *weight;
}

uint16_t storageDevice :: getCapacity()
{
	return *capacity;
}

void storageDevice :: printDataStorageDevice() const
{
	cout
		<< "Storage device make: " << make << endl
		<< "Storage device model: " << model << endl
		<< "Storage device reading speed: " << *readingSpeed << endl
		<< "Storage device write speed: " << *writeSpeed << endl
		<< "Storage device power consuption: " << *powerConsumption << endl
		<< "Storage device weight: " << *weight << endl
		<< "Storage device capacity: " << *capacity << endl;
}