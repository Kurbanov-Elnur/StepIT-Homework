#include <iostream>


struct UniqueCharacteristics
{
public:
    std::string Owner;
    std::string Number;

    UniqueCharacteristics(const std::string& owner, const std::string& plates)
    {
        Owner = owner;
        Number = plates;
    }

    friend std::ostream& operator<<(std::ostream& os, const UniqueCharacteristics& unique_Characteristics)
    {
        return os << "[ " << unique_Characteristics.Owner << " , " << unique_Characteristics.Number << " ]";
    }
};