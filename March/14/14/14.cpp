#include <iostream>
using namespace std;

#pragma region 
int main()
{
	int prices[3]{ 3, 6, 9 };

	char** name = new char* [2] {};
	name[0] = new char[10] {"citrus"};
	name[1] = new char[10] {"banan"};
	name[2] = new char[10] {"apple"};

	for (size_t i = 0; i < 3; i++)
	{
		for (size_t j = 0; j < 3; j++)
		{
			if ((int)name[i][0] < (int)name[j][0])
			{
				char* r1 = name[i];
				name[i] = name[j];
				name[j] = r1;
				int r2 = prices[i];
				prices[i] = prices[j];
				prices[j] = r2;
			}
		}
	}
	int max = prices[0], min = prices[0], imax{}, imin{};
	for (size_t i = 0; i < 3; i++)
	{
		if (prices[i] > max)
		{
			max = prices[i];
			imax = i;
		}
		else if (prices[i] < min)
		{
			min = prices[i];
			imin = i;
		}
	}
	cout
		<< "Min prices: " << name[imin] << endl
		<< "Max prices: " << name[imax] << endl;

	for (size_t i = 0; i < 3; i++)
	{
		cout << name[i] << ": " << prices[i] << "$" << endl;;
	}

	return 0;
}
#pragma endregion