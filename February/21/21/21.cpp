#include <iostream>
using namespace std;

#pragma region Task1
//int numbers[10];
//int numbers12[2][5]{};
//
//int main()
//{
//	for (size_t i = 0; i < 10; i++)
//	{
//		cout << "Enter number " << i << ": "; 
//		cin >> numbers[i];
//	}
//	for (size_t i = 0, j = 0, v = 5; i < 5 && v < 10; i++, j++, v++)
//	{
//		numbers12[0][i] = numbers[i];
//		numbers12[1][j] = numbers[v];
//	}
//
//	return 0;
//}
#pragma endregion

#pragma region Task2  
//int numbers[3][5]{};
//
//int main()
//{
//	for (size_t im = 0; im < 2; im++)
//	{
//		for (size_t i = 0; i < 5; i++)
//		{
//			cout << "Enter  number " << i + 1 << '-' << im + 1 << " array: ";
//			cin >> numbers[im][i];
//		}
//	}
//	for (size_t i = 0; i < 5; i++)
//	{
//		numbers[2][i] = numbers[0][i] + numbers[1][i];
//	}
//
//	return 0;
//}
#pragma endregion 

#pragma region Task3
//char week[7][10]{ "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
//int spentMoney[7]{};
//int sum{};
//
//int main()
//{
//	for (size_t i = 0; i < 7; i++)
//	{
//		cout << "Enter money spent " << week[i] << ": ";
//		cin >> spentMoney[i];
//	}
//
//	for (size_t i = 0; i < 7; i++)
//	{
//		sum += spentMoney[i];
//	}
//
//	cout << "Total amount spent per week: " << sum << endl;
//	sum = sum / 7;
//	cout << "Average amount spent per week: " << sum << endl;
//
//	for (size_t i = 0; i < 7; i++)
//	{
//		if (spentMoney[i] > 100)
//		{
//			cout << "On " << week[i] << " the amount exceeded 100$" << endl;
//		}
//	}
//
//	return 0;
//}
#pragma endregion

#pragma region Task4
//int main()
//{
//	char months[12][30]{ "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
//	float kurs[12]{ 0.94, 0.91, 0.97, 0.98, 1.02, 0.94, 0.96, 1.07, 1.02, 0.91, 0.94, 0.95};
//	int percent[12]{};
//	int sum[12]{};
//	int choice{};
//
//	for (size_t i = 0; i < 12; i++)
//	{
//		cout << "Enter percentage and amount for " << months[i] << ": ";
//		cin >> percent[i]; cin >> sum[i];
//	}
//
//	cout << "From which month do you want to withdraw the amount?"; cin >> choice;
//
//	for (size_t i = 0; i < 12; i++)
//	{
//		float balance{};
//
//		if (i == choice - 1)
//		{
//			balance = (sum[i] + (sum[i] / 100 * percent[i])) * kurs[i];
//
//			if (balance > 500)
//			{
//				balance = balance / 2;
//				cout << "You can pull out: " << balance << "$";
//			}
//			else
//				cout << "You can't pull out money for this month.";
//		}
//	}
//	return 0;
//}
#pragma endregion 