#include <iostream>
#include "GeneralCharacteristics.cpp"
#include "Unique—haracteristics.cpp"


class Car
{
    private:
        GeneralCharacteristics* General_Characteristics;
        UniqueCharacteristics* Unique_Characteristics;

    public:

        Car(const GeneralCharacteristics* general_Characteristics, const UniqueCharacteristics* unique_Characteristics)
        {
            General_Characteristics = new GeneralCharacteristics(*general_Characteristics);
            Unique_Characteristics = new UniqueCharacteristics(*unique_Characteristics);
        }

        GeneralCharacteristics* getGeneralCharacteristics() const
        {
            return General_Characteristics;
        }

        UniqueCharacteristics* getUniqueCharacteristics() const
        {
            return Unique_Characteristics;
        }

        void DisplayData()
        {
            std::cout << "Car data: " << std::endl;
            std::cout << *General_Characteristics << std::endl;
            std::cout << *Unique_Characteristics << std::endl;
        }
};