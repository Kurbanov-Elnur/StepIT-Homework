#include "Functions.h"


void addList(list*& Lists)
{
	getchar();

	cout << "Enter name: "; cin.getline(Lists[Lists->count].name, 100);
	cout << "Enter priority: "; cin.getline(Lists[Lists->count].priority, 30);
	cout << "Enter description: "; cin.getline(Lists[Lists->count].description, 1000);

	cout << "Enter day start: "; cin >> Lists[Lists->count].addDate[0];
	cout << "Enter month start: "; cin >> Lists[Lists->count].addDate[1];
	cout << "Enter year start: "; cin >> Lists[Lists->count].addDate[2];
	cout << "Enter execoyion time: "; cin >> Lists[Lists->count].executionTime;

	Lists->count++;
}

void showAll(list* Lists)
{
	for (size_t i = 0; i < Lists->count; i++)
	{
		cout << i + 1 << ':' << Lists[i].name << endl;
	}
}

void deleteList(list*& Lists)
{
	int choice{};
	cout << "Choose list to delete:" << endl;
	cin >> choice;

	getchar();

	int index = choice - 1;
	for (int i = choice - 1; i < Lists->count; ++i)
	{
		index++;
		Lists[i].name = Lists[i + 1].name;
		Lists[i].description = Lists[i + 1].description;
		Lists[i].priority = Lists[i + 1].priority;
		for (size_t j = 0; j < 3; j++)
		{
			Lists[i].addDate[j] = Lists[i + 1].addDate[j];
		}
	}
	Lists->count--;
}


void examination(int &obyekt)
{
	char vvod{};
	cout
		<< "Enter your choice: " << endl
		<< "1. Add" << endl
		<< "2. Delete" << endl;
	cin >> vvod;

	obyekt = (int)vvod - (int)'0';
}
