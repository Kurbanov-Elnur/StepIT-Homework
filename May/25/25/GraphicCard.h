#pragma once
#include "Computer.h" 

class graphicCard
{
private:
	string make{};
	string model{};
	string GPU{};
	string CUDA{};
	uint16_t* frequency = new uint16_t{};
	uint16_t* powerConsumption = new uint16_t{};
	uint16_t* transistors = new uint16_t{};
public:
	graphicCard(string make, string model, string GPU, string CUDA,
		uint16_t frequency, uint16_t powerConsumption, uint16_t transistors);

	string getMake();
	string getModel();
	string getGPU();
	string getCUDA();
	uint16_t getFrequency();
	uint16_t getPowerConsumption();
	uint16_t getTransistors();

	void pruitnDataGraphicCard() const;
};