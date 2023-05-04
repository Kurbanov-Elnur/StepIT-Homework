#include "Functions.h"

int main()
{
	list* Lists = new list[1000];
	int choice{};
	while (true)
	{
		cout
			<< "Enter your choice: " << endl
			<< "1. Add" << endl
			<< "2. Delete" << endl;
		examination(choice);

		switch (choice)
		{
			case 1:
				system("cls");
				addList(Lists);
				break;
			case 2:
				system("cls");
				showAll(Lists);
				deleteList(Lists);
				break;
			case 3:
				system("cls");
				showAll(Lists);
				editList(Lists);
				break;
			case 4:
				system("cls");
				searchName(Lists);
				break;
			case 5:
				system("cls");
				createTXT(Lists);
				break;
			default:
				break;
		}
	}

	return 0;
}