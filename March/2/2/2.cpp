#include <iostream>
using namespace std;

#pragma region Task1
//void degree(int number, int degre)
//{
//	int degref = 1;
//	for (size_t i = 0; i < degre; i++)
//	{
//		degref *= number;
//	}
//	cout << degref;
//}
//
//int main()
//{
//	int number{}, degre{};
//
//	cout << "Enter number: "; cin >> number;
//	cout << "Enter degree: "; cin >> degre;
//
//	degree(number, degre);
//
//	return 0;
//}
#pragma endregion

#pragma region Task2
//void range(int start, int end)
//{
//	int sum{};
//
//	for (size_t i = start + 1; i < end; i++)
//	{
//		sum += i;
//	}
//
//	cout << sum;
//}
//
//int main()
//{
//	int start{}, end{};
//
//	cout << "Enter start range: "; cin >> start;
//	cout << "Enter end range: "; cin >> end;
//
//	range(start, end);
//
//	return 0;
//}
#pragma endregion

#pragma region task3
//void perfection(int number)
//{
//	int sum{};
//
//	for (size_t i = 1; i < number; i++)
//	{
//		if (number % i == 0)
//		{
//			sum += i;
//		}
//	}
//	if (sum == number)
//	{
//		cout << "This number is perfect";
//	}
//	else
//	{
//		cout << "This number is not perfect";
//	}
//}
//
//int main()
//{
//	int number{};
//
//	cout << "Enter number: "; cin >> number;
//	
//	perfection(number);
//
//	return 0;
//}
#pragma endregion

#pragma region Task4
//void lucky(int number)
//{
//	int sum1{}, sum2{};
//
//	for (size_t i = 100000, j = 0; j < 3; j++, i /= 10)
//	{
//		sum1 += number / i % 10;
//	}
//	for (size_t i = 100, j = 0; j < 3; j++, i /= 10)
//	{
//		sum2 += number / i % 10;
//	}
//
//	if (sum1 == sum2)
//	{
//		cout << "This number is lucky";
//	}
//	else
//	{
//		cout << "This number is not lucky";
//	}
//}
//
//int main()
//{
//	int number{};
//	cout << "Enter number: "; cin >> number;
//
//	lucky(number);
//
//	return 0;
//}
#pragma endregion