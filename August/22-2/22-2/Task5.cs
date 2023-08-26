//Console.Write("Enter the expression: ");
//string expression = Console.ReadLine();

//int[] numbers = new int[100]; //Просто создал на 100, пожалуйста не придирайтесь)
//char[] tokens = new char[50];

//int t = 0, n = 0;
//for (int i = 0; i < expression.Length; i++)
//{
//    while(char.IsDigit(expression[i]))
//    {
//        if (numbers[n] != 0)
//            numbers[n] *= 10;
//        numbers[n] += (int)expression[i] - (int)'0';
//        if(i + 1 < expression.Length)
//        {
//            i++;
//            continue;
//        }
//        break;
//    }
//    n++;
//    if (expression[i] == '+' || expression[i] == '-')
//    {
//        tokens[t] = expression[i];
//        t++;
//    }
//}

//int res = numbers[0];

//for (int i = 0; tokens[i] != '\0'; i++)
//{
//    if (tokens[i] == '+')
//        res += numbers[i + 1];
//    else
//        res -= numbers[i + 1];
//}

//Console.WriteLine(res); ;