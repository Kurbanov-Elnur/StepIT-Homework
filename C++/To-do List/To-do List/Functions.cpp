#include "Functions.h"


void addList(list*& Lists)
{
	getchar();

	cout << "Enter name: "; cin.getline(Lists[Lists->count].name, 30);
	cout << "Enter priority: "; cin.getline(Lists[Lists->count].priority, 30);
	cout << "Enter description: "; cin.getline(Lists[Lists->count].description, 1000);

	cout << "Enter day start: "; 
	examination(Lists[Lists->count].addDate[0]);
	cout << "Enter month start: ";
	examination(Lists[Lists->count].addDate[1]);
	cout << "Enter year start: ";
	examination(Lists[Lists->count].addDate[2]);
	cout << "Enter execution time: ";
	examination(Lists[Lists->count].executionTime);

	Lists->count++;
}

void createTXT(list* Lists)
{

	char* fileName = new char[34]{};
	char* extension = new char[] {".txt"};
	
	int i{};
	while (Lists[1].name[i] != '\0')
	{
		fileName[i] = Lists[1].name[i];
		i++;
	}

	for (size_t j = 0; extension[j] != '\0'; j++)
	{
		fileName[i] = extension[j];
		i++;
	}

	cout << fileName << endl;


	FILE* file{};

	fopen_s(&file, fileName, "a");

	//fprintf(file, "Data: %s\n", Lists->name);
}

void showAll(list* Lists)
{
	for (size_t i = 0; i < Lists->count; i++)
	{
		cout << i + 1 << ": " << Lists[i].name << endl;
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
	char vvod [101]{};
	cin >> vvod;

	while ((int)vvod[0] < 47 || (int)vvod[0] > 58)
	{
		cout << "Please enter a number: "; cin >> vvod;
	}

	obyekt = (int)vvod[0] - (int)'0';
	if (((int)vvod[1] > 47 && (int)vvod[1] < 58))
	{
		obyekt *= 10;
		obyekt += (int)vvod[1] - (int)'0';
	}
}

void editList(list*& Lists)
{
	int c{};
	examination(c);

	getchar();

	cout << "Enter new name: "; cin.getline(Lists[c].name, 100);
	cout << "Enter new priority: "; cin.getline(Lists[c].priority, 30);
	cout << "Enter new description: "; cin.getline(Lists[c].description, 1000);

	cout << "Enter new day start: ";
	examination(Lists[c].addDate[0]);
	cout << "Enter new month start: ";
	examination(Lists[c].addDate[1]);
	cout << "Enter new year start: ";
	examination(Lists[c].addDate[2]);
	cout << "Enter new execution time: ";
	examination(Lists[c].executionTime);
}

void searchName(list* Lists)
{
		char search[31]{};
		int len{};

		getchar();
		cout << "Enter name: "; cin.getline(search, 30);

		while (search[len] != '\0')
			len++;

		for (size_t i = 0; i < Lists->count; i++)
		{
			int yes{};
			for (size_t j = 0; j < len; j++)
			{
				if (Lists[i].name[j] == search[j])
					yes++;
			}
			if (yes == len)
				cout << "Case numbered: " << i + 1 << endl;
		}
}

