#include "Functions.h"

int main()
{
	lists* toDoList{};
	createLists(toDoList);
	loadnames(toDoList);

	while (true)
	{
		int choice{};
		cout
			<< "Enter your choice: " << endl
			<< "1. Add " << endl
			<< "2. Show names" << endl
			<< "3. Edit work" << endl
			<< "4. Delete work" << endl
			<< "5. Search work" << endl;
		while (choice < 1 || choice > 5)
			examination(choice);

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
			loadnames(toDoList);
			toDoList[0].Spisok->print();
			break;
		case 3:
			system("cls");
			editList(toDoList);
			break;
		case 4:
			system("cls");
			deleteList(toDoList);
			break;
		case 5:
			system("cls");
			search(toDoList);
			break;
		default:
			break;
		}
	}

	return 0;
}