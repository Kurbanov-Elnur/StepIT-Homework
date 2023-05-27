#include <iostream>
using namespace std;

class Fraction
{
public:
	int numerator{}; // числитель
	int denominator{}; // знаменатель

	Fraction() = default;

	Fraction(int numerator, int denominator)
	{
		this->numerator = numerator;
		this->denominator = denominator;
	}

	Fraction addition(Fraction b);
	Fraction subtraction(Fraction b);
	Fraction multiplication(Fraction b);
	Fraction division(Fraction b);
};