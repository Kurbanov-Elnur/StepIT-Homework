#include <iostream>
using namespace std;

char* examination(int numbers[], char operators[])
{
	char* calculator = new char[1001]{};
	bool close = true;
 	while (close)
	{
		cout << "Enter example: "; cin.getline(calculator, 100);
		int len{}, l1{}, l2{};
		while (calculator[len] != '\0')
			len++;

		int i{};
		for (i; calculator[i] != '\0'; i++)
		{
			if (((int)calculator[i] < 48 || (int)calculator[i] > 57) && calculator[i] != ' ' && ((int)calculator[i] < 40 || (int)calculator[i] > 47))
					break;
		}

		if (i == len)
			close = false;

		for (size_t a = 0, j{}, v{}; calculator[a] != '\0'; a++)
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
			else if ((int)calculator[a] > 41 && (int)calculator[a] < 48)
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

	}


	return calculator;
}

int main()
{
	char* calculator {};
	int numbers[200]{};
	char operators[100]{};
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
		else if (operators[i] == '*')
		{
			if (i == 0)
			{
				res = numbers[j];
				j++;
			}
			res *= numbers[j];
			j++;
		}
		else if (operators[i] == '/')
		{
			if (i == 0)
			{
				res = numbers[j];
				j++;
			}
			res /= numbers[j];
			j++;
		}
	}
	cout << "Result: " << res << endl;
	
	return 0;
}