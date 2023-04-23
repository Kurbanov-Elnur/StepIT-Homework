#include "Functions.h"

int main()
{
	int count{};
	cout << "How many books do you want to add? "; cin >> count;
	getchar();

	book** books = new book*[10]{};

	for (size_t i = 0; i < count; i++)
	{
		books[i] = createBook(count);
	}

	sortName(books);
}