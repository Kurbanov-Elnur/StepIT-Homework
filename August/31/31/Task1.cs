//int Choice = 0;

//while (Choice <= 0 || Choice > 2)
//{
//    Console.WriteLine("Enter your choice: \n" +
//        "1. From decimal to binary \n" +
//        "2. From binary to decimal");
//    Int32.TryParse(Console.ReadLine(), out Choice);
//}

//int Number;
//Console.WriteLine("Enter number for convert: ");
//while (!Int32.TryParse(Console.ReadLine(), out Number));

//switch (Choice)
//{
//    case 1:
//        string Binary = "";

//        while(Number > 0)
//        {
//            Binary += Number % 2;
//            Number /= 2;
//        }

//        Console.WriteLine(Binary.Reverse().ToArray());
//        break;
//    case 2:
//        int Decimal = 0;
//        string Numbers = Number.ToString();

//        for (int i = 0; i < Numbers.Length; i++)
//        {
//            Decimal += int.Parse(Numbers[i].ToString()) * (int)Math.Pow(2, Numbers.Length - 1 - i);
//        }

//        Console.WriteLine(Decimal);
//        break;
//}