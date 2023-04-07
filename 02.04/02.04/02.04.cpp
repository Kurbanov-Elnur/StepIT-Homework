#include <iostream>
using namespace std;

int main()
{
	char* line = new char[101] {};
	char* linerep = new char[101] {};
	char* replace = new char[11] {};
	char* replacement = new char[11] {};

	cout << "Enter line: "; cin.getline(line, 100);
	cout << "Enter replace word: "; cin.getline(replace, 10);
	cout << "Enter a replacement word: "; cin.getline(replacement, 10);

	int count{}, count2{};
	while (replace[count] != '\0')
	{
		count++;
	}
	while (replacement[count2] != '\0')
	{
		count2++;
	}

	int yes{};
	for (size_t i = 0, f = 0; i < 100;)
	{
		if (line[i] == '\0')
			break;
		if ((int)line[i] > 64 && (int)line[i] < 91 || (int)line[i] == 32)
		{
			if ((int)line[i] == 32)
			{
				i++;
				f++;
				linerep[f - 1] = line[i - 1];
			}
			for (size_t j = 0, v = i; j < count; j++, v++)
			{
				if (line[v] == replace[j])
				{
					yes++;
				}
			}
			if (yes == count)
			{
				for (size_t j = 0; j < count2; j++)
				{
					if (replacement[j] == '\0')
						linerep[f] = ' ';
					else
						linerep[f] = replacement[j];
					f++;
				}
				int l{};
				while (l != count)
				{
					l++;
					i++;
				}
			}
			else
			{
				i++;
				f++;
				linerep[f - 1] = line[i - 1];
			}
			yes = 0;
		}
		else
		{
			linerep[f] = line[i];
			i++;
			f++;
		}
	}
	cout << linerep;
}

