#include <iostream>
using namespace std;

struct list
{
	char* name = new char[31] {};
	char* priority = new char[31] {};
	char* description = new char[1001] {};
	int	addDate[3]{};
	int executionTime{};
	int count{};
};

void addList(list*& Lists);
void showAll(list* Lists);
void deleteList(list*& Lists);
void examination(int &obyekt);
void editList(list*& Lists);
void searchName(list* Lists);