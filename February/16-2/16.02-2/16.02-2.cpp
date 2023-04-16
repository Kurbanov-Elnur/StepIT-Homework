#pragma region Task 1
//#include <iostream>
//using namespace std;
//
//int main()
//{
//	int start, end, number{};
//	cout << "Enter start range: "; cin >> start;
//	cout << "Enter end range: "; cin >> end;
//	cout << "Enter number: "; cin >> number;
//
//	srand(time(0));
//
//	int random = rand() % end + start;
//	cout << random << endl;
//	while (number != random)
//	{
//		cout << "Try again: "; cin >> number;
//	}
//	cout << "You turned off the number!";
// 
//  return 0;
//}
#pragma endregion

#pragma region Task 2
//#include <iostream>
//using namespace std;
//
//float garlands = 10, christmasTree = 10, crackers = 10, sparklers = 10;
//int garlandsPrices = 3, christmasTreePrices = 7, crackersPrices = 2, sparklersPrices = 1, ccount{}, choice{};
//float balance, overallBalance{}, choice2{}, ccount2{};
//bool choicekass = true;
//bool paid = false;
//
//int main()
//{
//	while (choicekass)
//	{
//		if (garlands == 0 && christmasTree == 0 && crackers == 0 && sparklers == 0)
//		{
//			cout << "We have run out of goods((";
//			break;
//		}
//
//		cout << "Continue: "; cin >> choice2;
//		choice = choice2;
//		if (choice == 0)
//			break;
//
//		choice = 0, balance = 0, ccount = 0;
//		bool choicepep = true;
//		bool paid{};
//
//		cout << "Hello, what do you want to buy?" << endl;
//		cout
//			<< "1 - Garlands: 3$	" << "Goods: " << garlands << endl
//			<< "2 - Christmas Tree: 7$	" << "Goods: " << christmasTree << endl
//			<< "3 - Crackers: 2$	" << "Goods: " << crackers << endl
//			<< "4 - Sparklers: 1$	" << "Goods: " << sparklers << endl;
//		cin >> choice2;
//		choice = choice2;
//
//		while (choice > 4 || choice == 0 || choice < 0)
//		{
//			cout << "This product does not exist, please re-enter: "; cin >> choice2;
//			choice = choice2;
//			cout << endl;
//		}
//
//		while (choicepep)
//		{
//			switch (choice)
//			{
//			case 1:
//			{
//				if (garlands == 0)
//				{
//					cout << "We have no garlands left(" << endl;
//					cout << "Enter another choice: " << endl; cin >> choice2;
//					choice = choice2;
//					continue;
//				}
//				cout << "Enter count product: " << endl; cin >> ccount2;
//				ccount = ccount2;
//
//				while (ccount > garlands || ccount < 0)
//				{
//					cout << "We don't have that many items, please re-enter: "; cin >> ccount2;
//					ccount = ccount2;
//					cout << endl;
//				}
//				balance += garlandsPrices * ccount;
//				garlands -= ccount;
//				break;
//			}
//			case 2:
//			{
//				if (christmasTree == 0)
//				{
//					cout << "We have no Christmas Tree left(" << endl;
//					cout << "Enter another choice: " << endl; cin >> choice2;
//					choice = choice2;
//					continue;
//				}
//				cout << "Enter count product: " << endl; cin >> ccount2;
//				ccount = ccount2;
//
//				while (ccount > christmasTree || ccount < 0)
//				{
//					cout << "We don't have that many items, please re-enter: "; cin >> ccount2;
//					ccount = ccount2;
//					cout << endl;
//				}
//				balance += christmasTreePrices * ccount;
//				christmasTree -= ccount;
//				break;
//			}
//			case 3:
//			{
//				if (crackers == 0)
//				{
//					cout << "We have no crackers left(" << endl;
//					cout << "Enter another choice: " << endl; cin >> choice2;
//					choice = choice2;
//					continue;
//				}
//				cout << "Enter count product: " << endl; cin >> ccount2;
//				ccount = ccount2;
//
//				while (ccount > crackers || ccount < 0)
//				{
//					cout << "We don't have that many items, please re-enter: "; cin >> ccount2;
//					ccount = ccount2;
//					cout << endl;
//				}
//				balance += crackersPrices * ccount;
//				crackers -= ccount;
//				break;
//			}
//			case 4:
//			{
//				if (sparklers == 0)
//				{
//					cout << "We have no sparklers left(" << endl;
//					cout << "Enter another choice: " << endl; cin >> choice2;
//					choice = choice2;
//					continue;
//				}
//				cout << "Enter count product: " << endl; cin >> ccount2;
//				ccount = ccount2;
//
//				while (ccount > sparklers || ccount < 0)
//				{
//					cout << "We don't have that many items, please re-enter: "; cin >> ccount2;
//					ccount = ccount2;
//					cout << endl;
//				}
//				balance += sparklersPrices * ccount;
//				sparklers -= ccount;
//				break;
//			}
//			}
//			cout << "Anything else ?" << endl; cin >> choice2;
//			choice = choice2;
//			while (choice > 4 || choice < 0)
//			{
//				cout << "This product does not exist, please re-enter: "; cin >> choice2;
//				choice = choice2;
//				cout << endl;
//			}
//			if (choice == 0)
//			{
//				choicepep = false;
//				float discount{};
//				cout << "If you have discounts, enter the discount: "; cin >> discount;
//				while (discount > 100 || discount < 0)
//				{
//					cout << "There is no such percentage. Please re-enter discount: "; cin >> discount;
//				}
//				balance = balance - ((balance / 100) * discount);
//				cout << "You must: " << balance << endl;
//				overallBalance += balance;
//				cout << "Successfully paid: "; cin >> paid;
//				if (paid)
//					cout << "\a";
//				system("cls");
//				continue;
//			}
//		}
//	}
//	cout << "Over All balance: " << overallBalance << "$";
//
//	return 0;
//}
#pragma endregion