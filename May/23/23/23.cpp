#include <iostream>
using namespace std;

struct dateOfBirth
{
	uint16_t day{};
	uint16_t month{};
	uint16_t year{};
};


class student
{
private:
	dateOfBirth* DateOfBirth = new dateOfBirth{};
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

	void addDataOfInstitution()
	{
		cout << "Enter name of Institution: "; cin >> this->nameOfTheInstitution;
		cout << "Enter Institute country: "; cin >> this->instituteCountry;
		cout << "Enter Institute city: "; cin >> this->instituteCity;
	}

	void printDataOfInstitution() const
	{
		cout
			<< "Name of the Institution: " << this->nameOfTheInstitution << endl
			<< "Country where the university is located: " << this->instituteCountry << endl
			<< "City where the university is located: " << this->instituteCity << endl;
	}

	void addDataStudent()
	{
		cout << "Enter name student: "; cin >> this->name;
		cout << "Enter surname student: "; cin >> this->surname;
		addDateOfBirth();
		cout << "Enter contact number: "; cin >> this->contactNumber;
		cout << "Enter city: "; cin >> this->city;
		cout << "Enter country: "; cin >> this->country;
		cout << "Enter name group: "; cin >> this->nameGroup;
	}

	void printDataStudent() const
	{
		cout
			<< "Student name: " << this->name << endl
			<< "Student surname: " << this->surname << endl;

		printDataDateOfBirth();

		cout 	
			<< "Student contact number: " << this->contactNumber << endl
			<< "Student city: " << this->city << endl
			<< "Sudent country: " << this->country << endl
			<< "Sudent group name: " << this->nameGroup << endl;
	}

	void addDateOfBirth()
	{
		cout << "Enter day: ";
		while(DateOfBirth->day <= 0 || DateOfBirth->day > 31)
			cin >> DateOfBirth->day;
		cout << "Enter month: "; 
		while(DateOfBirth->month <= 0 || DateOfBirth->month > 12)
			cin >> DateOfBirth->month;
		cout << "Enter year: ";
		while(DateOfBirth->year < 1950 || DateOfBirth->year > 2007)
			cin >> DateOfBirth->year;
	}

	void printDataDateOfBirth() const
	{
		cout << "Date of birth: " << DateOfBirth->day << ':' << DateOfBirth->month << ':' << DateOfBirth->year << endl;
	}
};


class Database
{
public:
	student* person{};
	uint16_t count{};
};


int main()
{
	Database* STEP = new Database{};

	int choice{};
	bool exit = true;

	while (exit)
	{
		cout
			<< "Enter choice: " << endl
			<< "1. Add student" << endl
			<< "2. Print data student" << endl
			<< "3. Exit the program" << endl;
			cin >> choice;

		switch (choice)
		{
			case 1:
				system("cls");
				STEP[STEP->count].person = new student{};
				STEP[STEP->count].person->addDataOfInstitution();
				STEP[STEP->count].person->addDataStudent();
				STEP->count++;
				break;
			case 2:
				system("cls");
				cout << "Choice a student: " << endl;
				for (uint16_t i = 1; i < STEP->count + 1; i++)
					cout << i << ". " << STEP[i - 1].person->name << endl;
				cin >> choice;

				STEP[choice - 1].person->printDataOfInstitution();
				STEP[choice - 1].person->printDataStudent();
				break;
			case 3:
				exit = false;
				break;
		}
	}

	return 0;
}