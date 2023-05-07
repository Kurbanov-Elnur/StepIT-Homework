#include <iostream>
#include <Windows.h>
using namespace std;

void getClick(int& x, int& y)
{
	HANDLE hConsoleIn = GetStdHandle(STD_INPUT_HANDLE);
	INPUT_RECORD inputRec;
	DWORD events;
	COORD coord;
	bool clicked = false;

	DWORD fdwMode = ENABLE_EXTENDED_FLAGS | ENABLE_WINDOW_INPUT | ENABLE_MOUSE_INPUT;
	SetConsoleMode(hConsoleIn, fdwMode);

	while (!clicked) {

		ReadConsoleInput(hConsoleIn, &inputRec, 1, &events);

		if (inputRec.EventType == MOUSE_EVENT) {
			if (inputRec.Event.MouseEvent.dwButtonState == FROM_LEFT_1ST_BUTTON_PRESSED) {
				coord = inputRec.Event.MouseEvent.dwMousePosition;
				x = coord.X;
				y = coord.Y;
				clicked = true;
			}
		}
		if (GetAsyncKeyState(VK_ESCAPE)) {
			cout << "Exiting" << endl;
			break;
		}
		else if (inputRec.EventType == KEY_EVENT) {
			cout << inputRec.Event.KeyEvent.wVirtualKeyCode << endl;
		}
	}
}

void createField(int*& field, int y, int size)
{

	field = new int[size] {};
	int* count = new int[size]{};


	srand(time(0));
	int r{};
	for (size_t i = 0; i < size; i++)
	{
		r = rand() % (size / 2) + 1;
		if (count[r - 1] < 2)
		{
			field[i] = r;
			count[r - 1]++;
		}
		else
		{
			i--;
		}
	}
}

int main()
{
	int* field{};
	int x{}, y{};
	cout
		<< "Enter Field size: " << endl
		<< "1. 4X4" << endl
		<< "2. 6X6" << endl;
	getClick(x, y);
	while (y < 1 && y > 3)
	{
		cout << "Invalid input, re-enter: " << endl;
		getClick(x, y);
	}
	int size{};
	if (y == 1)
		size = 16;
	else
		size = 32;

	createField(field, y, size);
	int numbers[16]{ 80, 160, 240, 320, 81, 161, 241, 321, 82, 162, 242, 322, 83, 163, 243, 323 };
	bool stop = true;
	while (stop)
	{
		system("cls");
		for (size_t i = 0; i < size; i++)
		{
			cout << "\t* ";
			if ((i + 1) % 4 == 0)
				cout << endl;
		}
		getClick(x, y);
		int choice1 = (x *= 10) + y;
		getClick(x, y);
		int choice2 = (x *= 10) + y;
		for (size_t i = 0; i < size; i++)
		{
			if (choice1 == numbers[i]|| numbers[i] == choice2)
				cout << "\t " << field[i];
			else
			{
				cout << "\t *";
				if ((i + 1) % 4 == 0)
					cout << endl;
			}
		}
		int a{}; 
		cout << "fvbuysfn:";
		cin >> a;
		system("cls");
	}
}