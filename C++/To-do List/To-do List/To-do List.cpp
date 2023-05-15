#include "Functions.h"
int main()
{
	lists* toDoList = createLists(toDoList);
	loading(toDoList);

	while (true)
	{
		int choice{};
		cout
			<< "Enter your chocie: " << endl
			<< "1. Add " << endl
			<< "2. Show names" << endl;
		cin >> choice;

		switch (choice)
		{
		case 1:
			system("cls");
			toDoList[toDoList->count].Spisok = addList();
			toDoList[toDoList->count].savetoFile();
			toDoList->count++;
			break;
		case 2:
			system("cls");
			for (size_t i = 0; i < toDoList->count; i++)
			{
				toDoList[i].Spisok->print();
			}
		default:
			break;
		}
	}
}