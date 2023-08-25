#region Task 1
//void FizzBuzz(ref int number)
//{
//    if (number % 3 == 0 && number % 5 == 0)
//        Console.WriteLine("Fizz Buzz");
//    else if (number % 3 != 0 && number % 5 != 0)
//        Console.WriteLine(number);
//    else if (number % 3 == 0)
//        Console.WriteLine("Fizz");
//    else
//        Console.WriteLine("Buzz");
//}

//int number = 0;

//bool checkoutNumber = false; 

//while (!checkoutNumber || number <= 0 || number > 100)
//{
//    Console.Write("Enter number: ");
//    checkoutNumber = Int32.TryParse(Console.ReadLine(), out number);
//}

//FizzBuzz(ref number);
#endregion

#region Task 2
//int value = 0, percent = 0;

//bool checkoutNumber = false;

//while (!checkoutNumber)
//{
//    Console.Write("Enter value: ");
//    checkoutNumber = Int32.TryParse(Console.ReadLine(), out value);
//}

//checkoutNumber = false;

//while (!checkoutNumber || percent < 0 || percent > 100)
//{
//    Console.Write("Enter percent: ");
//    checkoutNumber = Int32.TryParse(Console.ReadLine(), out percent);
//}

//float result = value / percent;

//Console.WriteLine(percent + " percent of " + value + " = " + result);
#endregion

#region Task 3
//void checkoutNumber(out int number)
//{
//    number = 0;
//    bool checkoutNumber = false;

//    while (!checkoutNumber || number < 0 || number > 9)
//    {
//        checkoutNumber = Int32.TryParse(Console.ReadLine(), out number);
//    }
//}

//int[] numbers = new int[4];

//for (int i = 0; i < 4; i++)
//{
//    Console.Write("Enter number " + (i + 1) + ": ");
//    checkoutNumber(out numbers[i]);
//}

//int result = 0, multiplier = 1000;
//for (int i = 0; i < 4; i++)
//{
//    result += numbers[i] * multiplier;
//    multiplier /= 10;
//}

//Console.WriteLine("Number: " + result);
#endregion

#region Task 4
//int number = 0, divisor = 100000, firstIndex = 0, secondIndex = 0;
//int[] numbers = new int[6];

//bool checkoutNumber = false;

//while (!checkoutNumber || number < 100000 || number > 999999)
//{
//    Console.Write("Enter number: ");
//    checkoutNumber = Int32.TryParse(Console.ReadLine(), out number);
//}

//for (int i = 0; i < 6; i++)
//{
//    numbers[i] = number / divisor; 
//    number %= divisor; 
//    divisor /= 10; 
//}

//checkoutNumber = false;

//while (!checkoutNumber || firstIndex <= 0 || firstIndex > 6)
//{
//    Console.Write("Enter index first number for exchange: ");
//    checkoutNumber = Int32.TryParse(Console.ReadLine(), out firstIndex);
//}

//checkoutNumber = false;

//while (!checkoutNumber || secondIndex <= 0 || secondIndex > 6)
//{
//    Console.Write("Enter index second number for exchange: ");
//    checkoutNumber = Int32.TryParse(Console.ReadLine(), out secondIndex);
//}

//int temp = numbers[firstIndex - 1];
//numbers[firstIndex - 1] = numbers[secondIndex - 1];
//numbers[secondIndex - 1] = temp;

//int result = 0;

//for (int i = 0; i < 6; i++)
//{
//    result += numbers[i];
//    result *= 10;
//}
//result /= 10;

//Console.WriteLine("Result: " + result);
#endregion

#region Task 5
//string GetSeason(DateTime date)
//{
//    int month = date.Month;

//    if (month == 12 || month == 1 || month == 2)
//        return "Winter";
//    else if (month == 3 || month == 4 || month == 5)
//        return "Spring";
//    else if (month == 6 || month == 7 || month == 8)
//        return "Summer";
//    else
//        return "Fall";
//}

//Console.Write("Enter the date in the format DD.MM.YYYY:");
//if (DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
//{
//    string season = GetSeason(date);
//    Console.WriteLine("Season: " + season + "\nDay of week: " + date.ToString("dddd"));
//}
//else
//{
//    Console.WriteLine("Incorrect date format.");
//}
#endregion

#region Task 6
//float temperature = 0;
//int choice = 0;

//bool checkoutNumber = false;

//while (!checkoutNumber || choice < 1 || choice > 2)
//{
//    Console.Write("Enter your choice: \n" +
//        "1. From Celsius to Fahrenheit \n" +
//        "2. From Fahrenheit to Celsius");
//    checkoutNumber = Int32.TryParse(Console.ReadLine(), out choice);
//}

//checkoutNumber = false;

//while (!checkoutNumber)
//{
//    Console.Write("Enter temperature: ");
//    checkoutNumber = float.TryParse(Console.ReadLine(), out temperature);
//}

//switch (choice)
//{
//    case 1:
//        float fahrenheit = temperature * 9 / 5 + 32;
//        Console.WriteLine(temperature + " celsius to fahrenheit: " + fahrenheit);
//        break;
//    case 2:
//        float celsius = (temperature - 32) * 5 / 9;
//        Console.WriteLine(temperature + " fahrenheit to celsius: " + celsius);
//        break;
//}
#endregion

#region Task 7
//int start = 0, end = 0;

//bool checkoutNumber = false;

//while (!checkoutNumber)
//{
//    Console.Write("Enter the beginning of the range: ");
//    checkoutNumber = Int32.TryParse(Console.ReadLine(), out start);
//}

//checkoutNumber = false;

//while (!checkoutNumber)
//{
//    Console.Write("Enter the end of the range: ");
//    checkoutNumber = Int32.TryParse(Console.ReadLine(), out end);
//}

//if(start > end)
//{
//    int temp = end;
//    end = start;
//    start = end;
//}

//for (int i = start; i <= end; i++)
//{
//    if(i % 2 == 0)
//        Console.WriteLine(i);
//}
#endregion