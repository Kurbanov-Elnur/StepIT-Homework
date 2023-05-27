#include "Class.h"

void enter(int &num, int &den)
{
	cout << "Enter the numerator of the fraction: "; cin >> num;
	cout << "Enter the denominator of the fraction: "; cin >> den;
}

void printAnswer(Fraction answer)
{
	cout
		<< "Answer numerator: " << answer.numerator << endl
		<< "Answer denominator: " << answer.denominator << endl;
}

int main()
{
	int choice{};
	int num{}, den{};

	enter(num, den);
	Fraction first(num, den);

	cout
		<< "Enter choice: " << endl
		<< "1. Addition" << endl
		<< "2. Subtraction" << endl
		<< "3. Multiplication" << endl
		<< "4. Divicion" << endl;
	cin >> choice;
	if(choice > 4 || choice <= 0)
		cout << "Invalid input! Good bye)";

	enter(num, den);
	Fraction second(num, den);

	if (choice == 1)
	{
		Fraction answer = first.addition(second);

		printAnswer(answer);
	}
	else if (choice == 2)
	{
		Fraction answer = first.subtraction(second);

		printAnswer(answer);
	}
	else if (choice == 3)
	{
		Fraction answer = first.multiplication(second);

		printAnswer(answer);
	}
	else if (choice == 4)
	{
		Fraction answer = first.division(second);

		printAnswer(answer);
	}

	return 0;
}