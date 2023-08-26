//int[] arr1 = new int[5];
//int[,] arr2 = new int[3,4];

//Console.WriteLine("Please enter the numbers in the range: 1 - 100");

//for (int i = 0; i < 5; i++)
//{
//    bool checkoutNumber = false;

//    while(!checkoutNumber || arr1[i] < 0 || arr1[i] > 100)
//    {
//        Console.Write("Enter " + (i + 1) + " number: ");
//        checkoutNumber = Int32.TryParse(Console.ReadLine(), out arr1[i]);
//    }
//}

//Random random = new Random();

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        arr2[i, j] = random.Next(0, 101); 
//    }
//}

//#region Data output
//Console.WriteLine("Array 1: ");
//for (int i = 0; i < 5; i++)
//{
//    Console.Write(arr1[i] + "\t");
//}

//Console.WriteLine("\nArray 2: ");
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        Console.Write(arr2[i, j] + "\t");
//    }
//    Console.WriteLine();
//}


// В программе я отдельно нахожу макс и мин хотя могу и в одном форе, но это будет не правильно, так как условия требуют общее максимальное, 
// И из-за этого когда не находится максимального у второго массива я делаю его нулем, что бы находить следующее. И именно из-за этого я не
// использовать один фор для нахождения нескольких вещей, так как элемент который я сделаю нулем может быть общим минимальным, и поэтому я 
// всё ищу отдельно. Это сообщения я написал что бы вы не подумали он же мог сделать в одном форе - минус бал. Я старался, поставьте пж 12))

#region Total maximum
//int[] tempArr = new int[5];
//arr1.CopyTo(tempArr, 0);

//int searchMax(int[] arr1, int[,] arr2)
//{
//    for (int i = 0; i < 5; i++)
//    {
//        for (int j = 0; j < 3; j++)
//        {
//            for (int k = 0; k < 4; k++)
//            {
//                if (arr2[j, k] == arr1.Max())
//                    return arr1.Max(); // вот это  причина по которой я использую функцию, так как мне нужно останавливать цикл при нахождении 
//                 // макс, а обычный break останавливает только один цикл
//            }
//        }
//        arr1[Array.IndexOf(arr1, arr1.Max())] = 0;
//    }
//    return 0;
//}

//int max = searchMax(tempArr, arr2);

//Console.WriteLine("Total max number: " + max);
#endregion

#region Total min
//int[] tempArr = new int[5];
//arr1.CopyTo(tempArr, 0);
//int searchMin(int[] arr1, int[,] arr2)
//{
//    for (int i = 0; i < 5; i++)
//    {
//        for (int j = 0; j < 3; j++)
//        {
//            for (int k = 0; k < 4; k++)
//            {
//                if (arr2[j, k] == arr1.Min())
//                    return arr1.Min(); 
//            }
//        }
//        arr1[Array.IndexOf(arr1, arr1.Min())] = 0;
//    }
//    return 0;
//}

//int min = searchMin(tempArr, arr2);

//Console.WriteLine("Total min number: " + min);
#endregion

#region Sum and Product
//int sumArr1 = 0, sumArr2 = 0;
//int productArr1 = 1, productArr2 = 1;

//for (int i = 0; i < 5; i++)
//{
//    sumArr1 += arr1[i];
//    productArr1 *= arr1[i];
//}

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        sumArr2 += arr2[i, j];
//        productArr2 += arr2[i, j];
//    }
//}

//Console.WriteLine("The sum of all the numbers in the first array: " + sumArr1);
//Console.WriteLine("The sum of all the numbers in the second array: " + sumArr1);
//Console.WriteLine("The product of all the numbers in the second array: " + productArr1);
//Console.WriteLine("The product of all the numbers in the second array: " + productArr2);
#endregion

#region Sum2
//int sumArr1 = 0, sumArr2 = 0;

//for (int i = 0; i < 5; i++)
//{
//    if (arr1[i] % 2 == 0)
//        sumArr1 += arr1[i];
//}

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        if(j % 2 != 0)
//            sumArr2 += arr2[i, j];
//    }
//}

//Console.WriteLine("Sum of even elements of the first array: " + sumArr1);
//Console.WriteLine("Sum of odd columns of the second array: " + sumArr2);
#endregion