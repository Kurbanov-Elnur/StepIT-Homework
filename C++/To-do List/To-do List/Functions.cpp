#include "Functions.h"

char* loading(lists* todolists)
{
	FILE* names{};

	fopen_s(&names, "names.txt", "a+");

	if (names == nullptr) {
		cout << "Error" << endl;
		return nullptr;
	}

	while (!feof(names)) {
		char* str = new char[31] {};
		fgets(str, 30, names);
		todolists[todolists->count].Spisok = new list{};
		todolists[todolists->count].Spisok->name = str;
		todolists->count++;
	}

	fclose(names);

	if (todolists->count > 0)
	{
		for (size_t i = 0; i < todolists->count - 1; i++)
		{
			char* fileName = new char[31] {};
			char* extension = new char[] {".txt"};

			int z{};
			while (todolists[i].Spisok->name[z] != '\0')
			{
				fileName[z] = todolists[i].Spisok->name[z];
				z++;
			}
			fileName[z - 1] = '\0';
			z--;

			for (size_t j = 0; extension[j] != '\0'; j++, z++)
				fileName[z] = extension[j];
			FILE* lists0{};

			fopen_s(&lists0, fileName, "r");

			fgets(todolists[i].Spisok->name, 30, lists0);
			fgets(todolists[i].Spisok->priority, 30, lists0);
			fgets(todolists[i].Spisok->description, 1000, lists0);
			fgets(todolists[i].Spisok->addDate, 2, lists0);
			fgets(todolists[i].Spisok->executionTime, 2, lists0);
			fclose(lists0);
		}
	}
}

list* addList()
{
	list* l = new list{};
	getchar();
	cout << "Enter name: ";
	cin.getline(l->name, 30);

	cout << "Enter priority: ";
	cin.getline(l->priority, 30);

	cout << "Enter description: ";
	cin.getline(l->description, 1000);
	cout << "Enter start day: "; cin.getline(l->addDate, 4);
	cout << "Enter Execution Time: "; cin.getline(l->executionTime, 4);
	cout << endl;
	return l;
}

lists* createLists(lists*& todolist)
{
	todolist = new lists{};
	cout << "Enter name: "; cin.getline(todolist->name, 30);

	todolist->Spisok = new list[100]{};

	return todolist;
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

