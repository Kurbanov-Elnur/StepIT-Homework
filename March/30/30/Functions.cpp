#include <iostream>
#include "Functions.h";

int mystrcmp(char* str1, char* str2)
{
	int length1{}, length2{};

	for (size_t i = 0; i < 52; i++)
	{
		if (str1[i] == '\0')
			break;
		length1++;
	}	
	for (size_t i = 0; i < 52; i++)
	{
		if (str2[i] == '\0')
			break;
		length2++;
	}

	return (length1 == length2) ? 0 : (length1 > length2) ? 1 : -1;
}

void StringToNumber(char* string)
{
	int* strtonum = new int[51] {};
	
	for (size_t i = 0; i < 52; i++)
	{
		if (string[i] == '\0')
			break;
		strtonum[i] = (int)string[i];
	}
	for (size_t i = 0; i < 52; i++)
	{
		if (string[i] == '\0')
			break;
		std::cout << strtonum[i];
	}
}

void NumberToString(int* number)
{
	char* numtostr = new char[51] {};

	for (size_t i = 0; i < 52; i++)
	{
		if (number[i] == '\0')
			break;
		numtostr[i] = (char)number[i];
	}
	for (size_t i = 0; i < 52; i++)
	{
		if (number[i] == '\0')
			break;
		std::cout << numtostr[i];
	}
}

char* Uppercase(char* str1)
{
	char* upperstring = new char[51] {};

	for (size_t i = 0; i < 52; i++)
	{
		if (str1[i] == '\0')
			break;
		if ((int)str1[i] > 96 && (int)str1[i] < 123)
		{
			upperstring[i] = (char)((int)str1[i] - 32);
		}
		else
			upperstring[i] = str1[i];
	}

	return upperstring;
}

char* Lowercase(char* str1)
{
	char* lowerstring = new char[51] {};

	for (size_t i = 0; i < 52; i++)
	{
		if (str1[i] == '\0')
			break;
		if ((int)str1[i] > 64 && (int)str1[i] < 91)
		{
			lowerstring[i] = (char)((int)str1[i] + 32);
		}
		else
			lowerstring[i] = str1[i];
	}

	return lowerstring;
}

char* mystrrev(char* str)
{
	char* reversstring = new char[51] {};

	int i{};
	while (str[i] != '\0')
	{
		i++;
	}

	for (int j = i, v = 0; j != -1; j--, v++)
	{
		reversstring[v] = str[j];
	}

	return reversstring;
}


