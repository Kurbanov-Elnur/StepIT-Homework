#include <iostream>

struct dateOfBirth
{
private:
	uint16_t day{};
	uint16_t month{};
	uint16_t year{};
public:
	dateOfBirth(uint16_t day, uint16_t month, uint16_t year)
	{
		this->day = day;
		this->month = month;
		this->year = year;
	}

	uint16_t getDay();
	uint16_t getMonth();
	uint16_t getYear();
};