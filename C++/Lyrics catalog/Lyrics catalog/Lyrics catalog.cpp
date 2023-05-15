#include "Functions.h"

int main()
{
	songs* Songs{};
	createSongs(Songs);
	loadSongs(Songs);

	while (true)
	{
		int choice{};
		cout
			<< "Enter your choice: " << endl
			<< "1. Add " << endl
			<< "2. Show names" << endl
			<< "3. Delete song" << endl
			<< "4. Edit song" << endl;
		while (choice < 1 || choice > 4)
			examination(choice);

	switch (choice)
	{
		case 1:
			system("cls");
			Songs[Songs->count].Song = addSong();
			Songs[Songs->count].savetoFile();
			Songs->count++;
			break;
		case 2:
			system("cls");
			loadSongs(Songs);
			for (size_t i = 0; i < Songs->count; i++)
				Songs[i].Song->print();
			break;
		case 3:
			system("cls");
			deleteSong(Songs);
			break;
		case 4:
			system("cls");
			editSongs(Songs);
			break;
		default:
			break;
	}

	}
}