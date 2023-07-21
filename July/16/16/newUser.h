#include <iostream>

class User {
private:
    std::string name{};
    std::string surname{};
    std::string email{};
    std::string password{};
    std::string phone{};
public:
    User() = default;

    User(std::string& name, std::string& surname, std::string& email, std::string& password, std::string& phone) {
        this->name = name;
        this->surname = surname;
        this->email = email;
        this->password = password;
        this->phone = phone;
    }

    char* tostring()
    {
        char* str = new char[250] {};
        char data[5][50]{};
        name.copy(data[0], sizeof(name));
        surname.copy(data[1], sizeof(surname));
        email.copy(data[2], sizeof(email));
        password.copy(data[3], sizeof(password));
        phone.copy(data[4], sizeof(phone));
        sprintf_s(str, 250, "%s\n%s\n%s\n%s\n%s\n", data[0], data[1], data[2], data[3], data[4]);
        return str;
    }

    std::string getName() const{
        return this->name;
    }

    std::string getSurname() const{
        return this->surname;
    }

    std::string getEmail() const{
        return this->email;
    }

    std::string getPassword() const {
        return this->password;
    }

    std::string getPhone() const{
        return this->phone;
    }
};
