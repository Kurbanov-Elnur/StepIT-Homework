#include <iostream>
using namespace std;

struct list
{
	char* name = new char[101] {};
	char* priority = new char[31] {};
	char* description = new char[1001] {};
	int start[3]{};
	int end[3]{};
	int count{};
};

void addList(list* Lists)
{
	cout << "Enter name: "; cin.getline(Lists->name, 100);
	cout << "Enter priority: "; cin.getline(Lists->description, 1000);
	cout << "Enter day start: "; cin >> Lists->start[0];
	cout << "Enter month start: "; cin >> Lists->start[1];
	cout << "Enter year start: "; cin >> Lists->start[2];
	cout << "Enter day end: "; cin >> Lists->end[0];
	cout << "Enter month end: "; cin >> Lists->end[1];
	cout << "Enter year end: "; cin >> Lists->end[2];

}



int main()
{
	list* Lists = new list[1000];
	addList(Lists);

	return 0;
}