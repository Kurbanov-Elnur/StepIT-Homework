//Console.WriteLine("Enter expression: ");
//string expression = Console.ReadLine();

//try
//{
//    if (expression.Contains("."))
//        throw new Exception("Invalid Input");
//}catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//    Environment.Exit(0);
//}

//int[] numbers = new int[2];
//string token = "";

//for (int i = 0, index = 0; i < expression.Length; i++)
//{
//    while (char.IsDigit(expression[i]))
//    {
//        if (numbers[index] != 0)
//            numbers[index] *= 10;
//        numbers[index] += (int)expression[i] - (int)'0';
//        if (i + 1 < expression.Length)
//        {
//            i++;
//            continue;
//        }
//        break;
//    }
//    if(i + 1 < expression.Length)
//    {
//        token += expression[i];
//        if (char.IsDigit(expression[i + 1]))
//            index++;
//    }
//}

//switch(token)
//{
//    case ">":
//        Console.WriteLine(numbers[0] > numbers[1]);
//        break;
//    case "<":
//        Console.WriteLine(numbers[0] < numbers[1]);
//        break;
//    case ">=":
//        Console.WriteLine(numbers[0] >= numbers[1]);
//        break;
//    case "<=":
//        Console.WriteLine(numbers[0] <= numbers[1]);
//        break;
//    case "==":
//        Console.WriteLine(numbers[0] == numbers[1]);
//        break;
//    case "!=":
//        Console.WriteLine(numbers[0] != numbers[1]);
//        break;
//}