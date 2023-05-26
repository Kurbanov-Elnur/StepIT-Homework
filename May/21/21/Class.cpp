#include "Class.h"

Fraction Fraction :: addition(Fraction b)
{
	Fraction c{};

	c.denominator = denominator * b.denominator;
	c.numerator = (numerator * b.denominator) + (b.numerator * denominator);

	return c;
}


Fraction Fraction::subtraction(Fraction b)
{
	Fraction c{};

	int num = 1;
	if (b.denominator > denominator)
	{
		while ((b.denominator * num) % denominator != 0)
			num++;
		c.denominator = b.denominator * num;
	}
	else
	{
		while ((denominator * num) % b.denominator != 0)
			num++;
		c.denominator = denominator * num;
	}

	c.numerator = (numerator * (c.denominator / denominator)) - (b.numerator * (c.denominator / b.denominator));

	return c;
}

Fraction Fraction :: multiplication(Fraction b)
{
	Fraction c{};


}