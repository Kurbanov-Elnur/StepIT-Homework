#include <iostream>
#include <regex>

std::string input()
{
	std::string ex{};

	std::cout << "Enter your expression: "; std::cin >> ex;

	std::regex regexExpression("([0-9]+(\+|\.){1})+");

	if (!regex_match(ex, regexExpression))
		throw std::invalid_argument("Invalid input");

	return ex;
}

int main()
{
	try {
		std::string expression = input();
	}	catch(std::exception& e){
		std::cout << e.what() << std::endl;
	}







}