#include <iostream>
using namespace std;

#pragma region Option1
//struct dateOfBirth
//{
//	uint16_t day{};
//	uint16_t month{};
//	uint16_t year{};
//};
//
//
//class student
//{
//private:
//	dateOfBirth* DateOfBirth = new dateOfBirth{};
//	string nameOfTheInstitution{};
//	string instituteCountry{};
//	string instituteCity{};
//public:
//	string name{};
//	string surname{};
//	string contactNumber{};
//	string city{};
//	string country{};
//	string nameGroup{};
//
//	student() = default;
//
//	student(string nameOfTheInstitution, string instituteCountry, string instituteCity, 
//		string name, string surname, string contactNumber, string city, string country, 
//		string nameGroup, uint16_t day, uint16_t month, uint16_t year)
//	{
//		this->nameOfTheInstitution = nameOfTheInstitution;
//		this->instituteCountry = instituteCountry;
//		this->instituteCity = instituteCity;
//		this->name = name;
//		this->surname = surname;
//		this->contactNumber = contactNumber;
//		this->city = city;
//		this->country = country;
//		this->nameGroup = nameGroup;
//		this->DateOfBirth->day = day;
//		this->DateOfBirth->month = month;
//		this->DateOfBirth->year = year;
//	}
//
//	string getNameUNI()
//	{
//		return this->nameOfTheInstitution;
//	}
//
//	string getCountryUNI()
//	{
//		return this->instituteCountry;
//	}
//
//	string getCityUNI()
//	{
//		return this->instituteCity;
//	}
//
//	void printDataStudent() const
//	{
//		cout
//			<< "Student name: " << this->name << endl
//			<< "Student surname: " << this->surname << endl
//			<< "Student day of birth: " << this->DateOfBirth->day << endl
//			<< "Student month of birth: " << this->DateOfBirth->month << endl
//			<< "Student year of birth: " << this->DateOfBirth->year << endl
//			<< "Student contact number: " << this->contactNumber << endl
//			<< "Student city: " << this->city << endl
//			<< "Sudent country: " << this->country << endl
//			<< "Sudent group name: " << this->nameGroup << endl;
//	}
//
//	uint16_t getDateOfBirth(int c) const
//	{
//		switch (c)
//		{
//			case 1:
//				return DateOfBirth->day;
//			case 2:
//				return DateOfBirth->month;
//			case 3:
//				return DateOfBirth->year;
//		}
//	}
//};
//
//
//class Database
//{
//public:
//	student* person{};
//	uint16_t count{};
//};
//
//
//int main()
//{
//	Database* STEP = new Database{};
//
//	int choice{};
//	bool exit = true;
//	string data[9]{};
//	dateOfBirth* DateOfBirth = new dateOfBirth{};
//
//	while (exit)
//	{
//		cout
//			<< "Enter choice: " << endl
//			<< "1. Add student" << endl
//			<< "2. Print data student" << endl
//			<< "3. Exit the program" << endl;
//			cin >> choice;
//
//			switch (choice)
//			{
//				case 1:
//					system("cls");
//					cout << "Enter name of Institution: "; cin >> data[0];
//					cout << "Enter Institute country: "; cin >> data[1];
//					cout << "Enter Institute city: "; cin >> data[2];
//					cout << "Enter name student: "; cin >> data[3];
//					cout << "Enter surname student: "; cin >> data[4];
//					cout << "Enter day: ";
//					while (DateOfBirth->day <= 0 || DateOfBirth->day > 31)
//						cin >> DateOfBirth->day;
//					cout << "Enter month: ";
//					while (DateOfBirth->month <= 0 || DateOfBirth->month > 12)
//						cin >> DateOfBirth->month;
//					cout << "Enter year: ";
//					while (DateOfBirth->year < 1950 || DateOfBirth->year > 2007)
//						cin >> DateOfBirth->year;
//					cout << "Enter contact number: "; cin >> data[5];
//					cout << "Enter city: "; cin >> data[6];
//					cout << "Enter country: "; cin >> data[7];
//					cout << "Enter name group: "; cin >> data[8];
//
//					student* s = new student(data[0], data[1], data[2], data[3], data[4], data[5],
//						data[6], data[7], data[8], DateOfBirth->day, DateOfBirth->month, DateOfBirth->year);
//
//					STEP[STEP->count].person = s;
//					STEP->count++;
//					break;
//				case 2:
//					system("cls");
//					cout << "Choice a student: " << endl;
//					for (uint16_t i = 0; i < STEP->count; i++)
//						cout << i + 1 << ". " << STEP[i].person->name << endl;
//					cin >> choice;
//
//					cout
//						<< "University name: " << STEP[choice - 1].person->getNameUNI() << endl
//						<< "University country: " << STEP[choice - 1].person->getCountryUNI() << endl
//						<< "University city: " << STEP[choice - 1].person->getCityUNI() << endl;
//					STEP[choice - 1].person->printDataStudent();
//					break;
//				case 3:
//					exit = false;
//			}
//	}
//
//	return 0;
//}
#pragma endregion

#pragma region Option2
//struct dateOfBirth
//{
//	uint16_t day{};
//	uint16_t month{};
//	uint16_t year{};
//};
//
//
//class student
//{
//private:
//	dateOfBirth* DateOfBirth = new dateOfBirth{};
//	string nameOfTheInstitution{};
//	string instituteCountry{};
//	string instituteCity{};
//public:
//	string name{};
//	string surname{};
//	string contactNumber{};
//	string city{};
//	string country{};
//	string nameGroup{};
//
//	void addDataOfInstitution()
//	{
//		cout << "Enter name of Institution: "; cin >> this->nameOfTheInstitution;
//		cout << "Enter Institute country: "; cin >> this->instituteCountry;
//		cout << "Enter Institute city: "; cin >> this->instituteCity;
//	}
//
//	void printDataOfInstitution() const
//	{
//		cout
//			<< "Name of the Institution: " << this->nameOfTheInstitution << endl
//			<< "Country where the university is located: " << this->instituteCountry << endl
//			<< "City where the university is located: " << this->instituteCity << endl;
//	}
//
//	void addDataStudent()
//	{
//		cout << "Enter name student: "; cin >> this->name;
//		cout << "Enter surname student: "; cin >> this->surname;
//		addDateOfBirth();
//		cout << "Enter contact number: "; cin >> this->contactNumber;
//		cout << "Enter city: "; cin >> this->city;
//		cout << "Enter country: "; cin >> this->country;
//		cout << "Enter name group: "; cin >> this->nameGroup;
//	}
//
//	void printDataStudent() const
//	{
//		cout
//			<< "Student name: " << this->name << endl
//			<< "Student surname: " << this->surname << endl;
//
//		printDataDateOfBirth();
//
//		cout
//			<< "Student contact number: " << this->contactNumber << endl
//			<< "Student city: " << this->city << endl
//			<< "Sudent country: " << this->country << endl
//			<< "Sudent group name: " << this->nameGroup << endl;
//	}
//
//	void addDateOfBirth()
//	{
//		cout << "Enter day: ";
//		while (DateOfBirth->day <= 0 || DateOfBirth->day > 31)
//			cin >> DateOfBirth->day;
//		cout << "Enter month: ";
//		while (DateOfBirth->month <= 0 || DateOfBirth->month > 12)
//			cin >> DateOfBirth->month;
//		cout << "Enter year: ";
//		while (DateOfBirth->year < 1950 || DateOfBirth->year > 2007)
//			cin >> DateOfBirth->year;
//	}
//
//	void printDataDateOfBirth() const
//	{
//		cout << "Date of birth: " << DateOfBirth->day << ':' << DateOfBirth->month << ':' << DateOfBirth->year << endl;
//	}
//};
//
//
//class Database
//{
//public:
//	student* person{};
//	uint16_t count{};
//};
//
//
//int main()
//{
//	Database* STEP = new Database{};
//
//	int choice{};
//	bool exit = true;
//
//	while (exit)
//	{
//		cout
//			<< "Enter choice: " << endl
//			<< "1. Add student" << endl
//			<< "2. Print data student" << endl
//			<< "3. Exit the program" << endl;
//		cin >> choice;
//
//		switch (choice)
//		{
//		case 1:
//			system("cls");
//			STEP[STEP->count].person = new student{};
//			STEP[STEP->count].person->addDataOfInstitution();
//			STEP[STEP->count].person->addDataStudent();
//			STEP->count++;
//			break;
//		case 2:
//			system("cls");
//			cout << "Choice a student: " << endl;
//			for (uint16_t i = 1; i < STEP->count + 1; i++)
//				cout << i << ". " << STEP[i - 1].person->name << endl;
//			cin >> choice;
//
//			STEP[choice - 1].person->printDataOfInstitution();
//			STEP[choice - 1].person->printDataStudent();
//			break;
//		case 3:
//			exit = false;
//			break;
//		}
//	}
//
//	return 0;
//}
#pragma endregion