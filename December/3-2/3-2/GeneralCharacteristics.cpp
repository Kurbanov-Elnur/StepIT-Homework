#include <iostream>


struct GeneralCharacteristics
{
public:
    std::string Brand;
    std::string Model;
    std::string Color;

    GeneralCharacteristics(const std::string& brand, const std::string& model, const std::string& color)
    {
        Brand = brand;
        Model = model;
        Color = color;
    }

    friend std::ostream& operator<<(std::ostream& os, const GeneralCharacteristics& general_Characteristics)
    {
        return os << "[ " << general_Characteristics.Brand << " , " << general_Characteristics.Model << " , " << general_Characteristics.Color << " ]";
    }
};