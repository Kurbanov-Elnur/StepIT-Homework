#pragma once
#include "Computer.h"

struct CPU
{
private:
	string make{};
	string model{};
	string frequency{};
	string performance{};
	string socket{};
public:
	CPU() = default;
	CPU(string make, string model, string frequency, string performance, string socket);

	string getMake();
	string getModel();
	string getFrequency();
	string getPerformance();
	string getSocket();

	void printDataCPU() const;
};