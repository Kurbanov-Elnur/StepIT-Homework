#include <iostream>
#include "Struct.h"
using namespace std;

class student
{
private:
	dateOfBirth* DateOfBirth{};
	string nameOfTheInstitution{};
	string instituteCountry{};
	string instituteCity{};
public:
	string name{};
	string surname{};
	string contactNumber{};
	string city{};
	string country{};
	string nameGroup{};

	student(string nameOfTheInstitution, string instituteCountry, string instituteCity,
		string name, string surname, string contactNumber, string city, string country,
		string nameGroup, uint16_t day, uint16_t month, uint16_t year)
	{
		this->nameOfTheInstitution = nameOfTheInstitution;
		this->instituteCountry = instituteCountry;
		this->instituteCity = instituteCity;
		this->name = name;
		this->surname = surname;
		this->contactNumber = contactNumber;
		this->city = city;
		this->country = country;
		this->nameGroup = nameGroup;
		dateOfBirth* d = new dateOfBirth (day, month, year);
		DateOfBirth = d;
	}

	string getNameUNI();
	string getCountryUNI();
	string getCityUNI();

	void printDataStudent() const;

	void getDateOfBirth(int c) const;
};

class Database
{
public:
	student* person{};
	uint16_t count{};
};