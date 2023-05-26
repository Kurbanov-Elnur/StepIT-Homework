#include <iostream>
using namespace std;




struct CPU
{
private:
	string make{};
	string model{};
	string frequency{};
	string performance{};
	string socket{};
public:
	CPU(string make, string model, string frequency, string performance, string socket)
	{
		this->make = make;
		this->model = model;
		this->frequency = frequency;
		this->performance = performance;
		this->socket = socket;
	}

	string getMake()
	{
		return make;
	}

	string getModel()
	{
		return model;
	}

	string getFrequency()
	{
		return frequency;
	}

	string getPerformance()
	{
		return performance;
	}

	string getSocket()
	{
		return socket;
	}
};


struct systemUnit
{

};


class Computer
{

};


int main()
{


	return 0;
}