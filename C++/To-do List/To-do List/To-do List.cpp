#include "Functions.h"

int main()
{
	list* Lists = new list[1000];
	int choice{};
	while (true)
	{
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
			default:
				break;
		}
	}

	return 0;
}