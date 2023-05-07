#include <iostream>
using namespace std;

char* examination(int*& numbers, char*& operators)
{
	bool close = true;
	char* calculator = new char[401] {};
	while (close)
	{
		numbers = new int[200] {};
		operators = new char[200] {};

		cout << "Enter example: "; cin.getline(calculator, 100);
		int l1{}, l2{};

		for (size_t i{}; (int)calculator[i] != (int)'\0'; i++)
		{
			if (((int)calculator[i] < 48 || (int)calculator[i] > 57) && calculator[i] != ' ' && ((int)calculator[i] < 40 || (int)calculator[i] > 47))
			{
				continue;
			}
		}
		close = false;

		for (size_t a = 0, j{}, v{}; (int)calculator[a] != (int)'\0'; a++)
		{
			if ((int)calculator[a] > 47 && (int)calculator[a] < 58)
			{
				numbers[j] = (int)calculator[a] - (int)'0';
				while ((int)calculator[a + 1] > 47 && (int)calculator[a + 1] < 58)
				{
					numbers[j] *= 10;
					a++;
					numbers[j] += (int)calculator[a] - (int)'0';
				}
				j++;
			}
			else if ((int)calculator[a] > 39 && (int)calculator[a] < 48)
			{
				operators[v] = calculator[a];
				v++;
			}
		}
		while (numbers[l1] != '\0')
			l1++;
		while (operators[l2] != '\0')
			l2++;

		if (l1 == l2 || l2 > l1)
			close = true;
		l1 = 0, l2 = 0;
		int z{};
		while (operators[z] != '\0')
		{
			if (operators[z] == '(')
				l1++;
			else if (operators[z] == ')')
				l2++;
			z++;
		}
		if (l1 != l2)
		{
			close = true;
			continue;
		}

		for (size_t i = 0, j{}; operators[i] != '\0'; i++)
		{
			if (operators[i] == '*')
			{
				numbers[i] = numbers[i] * numbers[i + 1];
				if (numbers[i + 1] != '\0')
					j = i + 1;
				else
					j = i;
				while (numbers[j + 1] != '\0')
				{
					numbers[j] = numbers[j + 1];
					j++;
				}
				j = i;
				while (operators[j] != '\0')
				{
					operators[j] = operators[j + 1];
					j++;
				}
				i--;
			}
			if (operators[i] == '/')
			{
				numbers[i] = numbers[i] / numbers[i + 1];
				if (numbers[i + 1] != '\0')
					j = i + 1;
				else
					j = i;
				while (numbers[j + 1] != '\0')
				{
					numbers[j] = numbers[j + 1];
					j++;
				}
				j = i;
				while (operators[j] != '\0')
				{
					operators[j] = operators[j + 1];
					j++;
				}
				i--;
			}
		}
	}

	return calculator;
}

int main()
{
	bool close = true;
	while (close)
	{
		char* calculator{};
		int* numbers{};
		char* operators{};
		int res{};

		calculator = examination(numbers, operators);

		for (size_t i = 0, j{}; operators[i] != '\0'; i++)
		{
			if (operators[i] == '+')
			{
				if (i == 0)
				{
					res += numbers[j];
					if (numbers[j + 1] != '\0')
						res += numbers[j + 1];
					j += 2;
				}
				else
				{
					res += numbers[j];
					j++;
				}
			}
			else if (operators[i] == '-')
			{
				if (i == 0 && numbers[j + 1] != '\0')
				{
					res = numbers[0];
					j++;
				}
				res -= numbers[j];
				j++;
			}
		}
		if (res == 0)
			cout << "Result: " << numbers[0] << endl;
		else
			cout << "Result: " << res << endl;

		cout << "Enter 0 to close: "; cin >> close;
		cin.ignore();
	}
	return 0;
}