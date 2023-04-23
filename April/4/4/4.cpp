#include <iostream>
using namespace std;

int main()
{
    char* len = new char[20] {"hello, world!"};
    string hello = "Hello";

    for (size_t i = 0; i < 20; i++)
    {
        if (len[i] == '\0')
            break;
        len[i] = toupper(len[i]);
    }


    cout << len;
}