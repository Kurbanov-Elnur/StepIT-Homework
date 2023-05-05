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

		for (size_t i = 0, j{}, v{}; calculator[i] != '\0'; i++)
		{
			if ((int)calculator[i] > 47 && (int)calculator[i] < 58)
			{
				numbers[j] = (int)calculator[i] - (int)'0';
				while ((int)calculator[i + 1] > 47 && (int)calculator[i + 1] < 58)
				{
					numbers[j] *= 10;
					i++;
					numbers[j] += (int)calculator[i] - (int)'0';
				}
				j++;
			}
			else if ((int)calculator[i] > 41 && (int)calculator[i] < 48)
			{
				operators[v] = calculator[i];
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

	cout << res;

}







#pragma region a
	/*for (size_t i = 0; calculator[i] != '\0';)
	{
		while ((int)calculator[i] > 47 && (int)calculator[i] < 58)
		{
			num += (int)calculator[i] - (int)'0';
			if ((int)calculator[i + 1] > 47 && (int)calculator[i + 1] < 58)
			{
				num *= 10;
			}
			i++;
		}
		if (calculator[i] == '+')
		{
			while ((int)calculator[i] < 47 || (int)calculator[i] > 58)
				i++;
			res += num;
			num = 0;
			while ((int)calculator[i] > 47 && (int)calculator[i] < 58)
			{
				num += (int)calculator[i] - (int)'0';
				if ((int)calculator[i + 1] > 47 && (int)calculator[i + 1] < 58)
				{
					num *= 10;
				}
				i++;
			}
			res += num;
			continue;
		}
		else if (calculator[i] == '-')
		{
			while ((int)calculator[i] < 47 || (int)calculator[i] > 58)
				i++;
			num = 0;
			while ((int)calculator[i] > 47 && (int)calculator[i] < 58)
			{
				num += (int)calculator[i] - (int)'0';
				if ((int)calculator[i + 1] > 47 && (int)calculator[i + 1] < 58)
				{
					num *= 10;
				}
				i++;
			}
			res -= num;
			continue;
		}
		i++;
	}
		//cout << *///res << endl;
#pragma endregion