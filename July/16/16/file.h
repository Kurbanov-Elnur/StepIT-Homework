#include "newUser.h"

namespace file
{
	void savetoFile(User* users, uint16_t usersCount)
	{
		FILE* file{};
		fopen_s(&file, "users.txt", "a+");

		if (file == nullptr)
		{
			std::cout << "Error" << std::endl;
			return;
		}

		fprintf(file, "%s", users[usersCount].tostring());

		fclose(file);
	}

	int length(char* obyekt)
	{
		int l{};
		while (obyekt[l] != '\n')
			l++;

		return l;
	}

	void loadnames(User*& users, uint16_t usersCount)
	{
		FILE* lists{};
		fopen_s(&lists, "users.txt", "r");

		if (lists == nullptr) {
			return;
		}

		while (!feof(lists)) {
			users[usersCount].Spisok = new list{};

			fgets(todolists[todolists->count].Spisok->name, 30, lists);
			todolists[todolists->count].Spisok->name[length(todolists[todolists->count].Spisok->name)] = '\0';
			fgets(todolists[todolists->count].Spisok->priority, 30, lists);
			todolists[todolists->count].Spisok->priority[length(todolists[todolists->count].Spisok->priority)] = '\0';
			fgets(todolists[todolists->count].Spisok->description, 1000, lists);
			todolists[todolists->count].Spisok->description[length(todolists[todolists->count].Spisok->description)] = '\0';
			fgets(todolists[todolists->count].Spisok->addDate, 8, lists);
			todolists[todolists->count].Spisok->addDate[length(todolists[todolists->count].Spisok->addDate)] = '\0';
			fgets(todolists[todolists->count].Spisok->executionTime, 8, lists);
			todolists[todolists->count].Spisok->executionTime[length(todolists[todolists->count].Spisok->executionTime)] = '\0';
			todolists->count++;
		}
		todolists->count--;

		fclose(lists);
	}
}
