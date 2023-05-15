#include <iostream>
using namespace std;

struct list
{
	char* name = new char[31] {};
	char* priority = new char[31] {};
	char* description = new char[1001] {};
	char* addDate = new char[5] {};
	char* executionTime = new char[5] {};

	char* tostring()
	{
		char* str = new char[1500] {};
		sprintf_s(str, 1500, "%s\n%s\n%s\n%s\n%s\n", name, priority, description, addDate, executionTime);
		return str;
	}

	void print()
	{
		cout
			<< "Name: " << name << endl
			<< "Priority: " << priority << endl
			<< "Description: " << description << endl
			<< "Add Date: " << addDate << endl
			<< "Execution time: " << executionTime << endl;
	}
};

struct lists
{
	char* name = new char[31] {};
	list* Spisok{};
	int count{};


	void savetoFile()
	{
		char* fileName = new char[31] {};
		char* extension = new char[] {".txt"};

		int i{};
		while (Spisok->name[i] != '\0')
		{
			fileName[i] = Spisok->name[i];
			i++;
		}

		for (size_t j = 0; extension[j] != '\0'; j++, i++)
			fileName[i] = extension[j];

		FILE* file{};
		FILE* names{};
		fopen_s(&names, "names.txt", "a+");
		fopen_s(&file, fileName, "w");

		if (file == nullptr || names == nullptr)
		{
			cout << "Error" << endl;
			return;
		}

		fprintf(names, "%s\n", Spisok->name);
		fprintf(file, "%s", Spisok->tostring());

		if (file != nullptr || names != nullptr)
		{
			fclose(file);
			fclose(names);
		}
	}

};

char* loading(lists* todolists);
list* addList();
lists* createLists(lists*& todolist);