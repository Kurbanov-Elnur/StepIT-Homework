#include <iostream>
using namespace std;

class Fraction
{
public:
	int numerator{};
	int denominator{};

	Fraction() = default;

	Fraction(int numerator, int denominator)
	{
		this->numerator = numerator;
		this->denominator = denominator;
	}

	Fraction addition(Fraction b);
	Fraction subtraction(Fraction b);
	Fraction multiplication(Fraction b);
};