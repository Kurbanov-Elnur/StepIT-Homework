#include <iostream>
using namespace std;

uint16_t ccount{};

struct Student
{
	char* name = new char[11];
	char* surname = new char[11];
	char* patronymic = new char[11];
	int grades[10]{};

	void printInfo()
	{
		cout
			<< endl << "Student name: " << name << endl
			<< "Student surname: " << surname << endl
			<< "Student patronomic: " << patronymic << endl;

		for (size_t i = 0; i < 10; i++)
		{
			cout << "Grades " << i + 1 << ":" << grades[i] << endl;
		}
	}

	void average()
	{
		int a{};
		for (size_t i = 0; i < 10; i++)
		{
			a += grades[i];
		}
		cout << "Average rating this student: " << a / 10;
	}
};

struct Students
{
	//char* name = new char[11];
	uint16_t capacity{ 20 };
	Student* students{};

	void createStudent()
	{
		if (ccount < capacity)
		{
			Student* s = new Student{};

			cout << "Enter student name: "; cin.getline(s->name, 10);
			cout << "Enter student surname: "; cin.getline(s->surname, 10);
			cout << "Enter student surname: "; cin.getline(s->patronymic, 10);

			students[ccount] = *s;
			ccount++;
		}
		else
			cout << "Class full";
	}

	void addGrades()
	{
			for (size_t i = 0; i < 10; i++)
			{
				cout << "Enter grades " << i + 1 << ":"; cin >> students->grades[i];
			}
	}
};

void createStudents(Students* &s)
{
	s = new Students{};

	//cout << "Enter name: "; cin.getline(s->name, 10);

	s->students = new Student[s->capacity];
}

void printStudents(Students* students)
{
	for (size_t i = 0; i < ccount; i++)
	{
		cout << i + 1 << name << endl;
	}
}

int main()
{
	Students* students{};
	createStudents(students);

	while (true)
	{
		int choice{};
		cout
			<< "1. Add student" << endl
			<< "2. Rate" << endl
			<< "3. Displaying a list of students" << endl
			<< "4. Printing student grades" << endl;
			//<< "5. "
		cin >> choice;

		switch (choice)
		{
			case 1:
				getchar();
				students->createStudent();
				break;
			case 2:
				printStudents(students);
				cin >> choice;
				students[choice].addGrades();
				break;
			case 3:
				printStudents(students);
			//case 4:
			//	printStudents(students);
			//	cin >> choice;
			//	students[choice].;
				break;
		}
	}
}
