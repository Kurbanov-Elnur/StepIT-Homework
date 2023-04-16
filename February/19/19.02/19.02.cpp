#include <iostream>
using namespace std;

#pragma region  Task1
//int numbers[10]{};
//
//int main()
//{
//	srand(time(0));
//
//	for (size_t i = 0; i < 10; i++)
//	{	
//		int num = rand() % 100 + 1;
//		numbers[i] = num;
//		cout << numbers[i] << " ";
//	}
//
//	cout << endl;
//	int max = numbers[0];
//
//	for (size_t i = 0; i < 10; i++)
//	{
//		if (numbers[i] > max)
//		{
//			max = numbers[i];
//		}
//	}
//	cout << "Max number: " << max << endl;
//
//	int min = numbers[0];
//	for (size_t i = 0; i < 10; i++)
//	{
//		if (numbers[i] < min)
//		{
//			min = numbers[i];
//		}
//	}
//	cout << "Min number: " << min;
// 
//  return 0;
//}
#pragma endregion

#pragma region Task2
//int numbers[10]{};
//int start, endd, num{};
//
//int main()
//{
//	cout << "enter start range: "; cin >> start;
//	cout << "enter end range: "; cin >> endd;
//
//	if(endd < start)
//	{
//		int normalization{};
//		normalization = endd;
//		endd = start;
//		start = normalization;
//	}
//	cout << "enter number: "; cin >> num;
//	srand(time(0));
//
//	for (size_t i = 0; i < 10; i++)
//	{
//		int num = rand() % (endd - start) + start;
//		numbers[i] = num;
//		cout << numbers[i] << " ";
//	}
//
//	int sum{};
//
//	for (size_t i = 0; i < 10; i++)
//	{
//		if (numbers[i] < num)
//		{
//			sum += numbers[i];
//		}
//	}
//	cout << endl << sum;
//
//	return 0;
//}
#pragma endregion

#pragma region Task3
//
//int numbers[12]{};
//int start, endd{};
//
//int main()
//{
//	for (size_t i = 0; i < 12; i++)
//	{
//		cout << "Enter profit of the month " << i + 1 << ':'; cin >> numbers[i];
//	}
//	
//	cout << "Enter start range: " << endl; cin >> start; 
//	cout << "Enter end range: " << endl; cin >> endd;
//	if(endd < start)
//	{
//		int normalization{};
//		normalization = endd;
//		endd = start;
//		start = normalization;
//	}
//
//	int min = numbers[start];
//	int month{};
//
//	for (int i = start - 1; i < endd; i++)
//	{
//		if (min > numbers[i])
//		{
//			month = i + 1;
//		}
//	}
//	cout << "Profits were minimal: Month " << month << endl;
//
//	int max = numbers[start];
//	month = 0;
//
//	for (int i = start - 1; i < endd; i++)
//	{
//		if (max < numbers[i])
//		{
//			month = i + 1;
//		}
//	}
//	cout << "Profits were maximal: Month " << month;
//
//	return 0;
//}
#pragma endregion 

#pragma region Task4
//
//int numbers[]{ 3, 6, 12, 73, -6, 14, 84, 151, 42, -4, 7, 123, 83, -8, 92, -4, 23, 31, 69, 72 };
//int minn = numbers[0], maxx = numbers[0], imin{}, imax{};
//int summinmax = 1, sumeven = 1, sumnegative{}, sumnegativenegative{};
//int negative1, negative2{};
//
//int main()
//{
//	for (size_t i = 0; i < 20; i++)
//	{
//		if (numbers[i] < 0)
//		{
//			sumnegative += numbers[i];
//		}
//	}
//	cout << sumnegative << endl;
//
//	for (size_t i = 0; i < 20; i++)
//	{
//		if (numbers[i] < minn)
//		{
//			minn = numbers[i];
//			imin = i;
//		}
//		if (numbers[i] > maxx)
//		{
//			maxx = numbers[i];
//			imax = i;
//		}
//	}
//
//	if (imax < imin)
//	{
//		int normalization{};
//		normalization = imax;
//		imax = imin;
//		imin = normalization;
//	}
//
//	for (size_t i = imin; i < imax; i++)
//	{
//		summinmax *= numbers[i];
//	}
//	cout << summinmax << endl;
//
//	for (size_t i = 0; i < 20; i++)
//	{
//		if (i % 2 == 0)
//		{
//			sumeven *= numbers[i];
//		}
//	}
//	cout << sumeven << endl;
//
//	for (size_t i = 0; i < 20; i++)
//	{
//		if (numbers[i] < 0)
//		{
//			negative1 = i;
//			break;
//		}
//	}
//
//	for (size_t i = 19; i >= 0 ; i--)
//	{
//		if (numbers[i] < 0)
//		{
//			negative2 = i;
//			break;
//		}
//	}
//
//	for (size_t i = negative1; i < negative2; i++)
//	{
//		sumnegativenegative += numbers[i];
//	}
//	cout << sumnegativenegative;
//
//	return 0;
//}
#pragma endregion

