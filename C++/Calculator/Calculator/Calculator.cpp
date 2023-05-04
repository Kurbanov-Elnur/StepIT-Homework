#include <iostream>
using namespace std;

void examination(int& obyekt)
{
	char vvod[101]{};
	cin >> vvod;

	while ((int)vvod[0] < 47 || (int)vvod[0] > 58)
	{
		cout << "Please enter a number: "; cin >> vvod;
	}

	obyekt = (int)vvod[0] - (int)'0';
	if (((int)vvod[1] > 47 && (int)vvod[1] < 58))
	{
		obyekt *= 10;
		obyekt += (int)vvod[1] - (int)'0';
	}
}

int main()
{
	char calculator[101] {};
	int res{};

	cout << "Enter example: "; cin.getline(calculator, 100);
	
	int num{};
	for (size_t i = 0; calculator[i] != '\0';)
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
		cout << res << endl;
}