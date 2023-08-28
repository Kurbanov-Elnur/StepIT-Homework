//int[] filtering(int[] arr, int[] filterArr)
//{
//    int[] result = new int[arr.Length];

//    for (int i = 0, j = 0; i < arr.Length; i++)
//    { 
//        if (!filterArr.Contains(arr[i]))
//            result[j++] = arr[i];
//    }

//    return result;
//}

//void printData(int[] arr)
//{
//    foreach (var item in arr)
//    {
//        Console.Write(item + "\t");
//    }
    
//    Console.WriteLine();
//}

//int[] createArr()
//{
//    int length = 0;

//    Console.Write("Enter the length array: ");
//    while (!Int32.TryParse(Console.ReadLine(), out length));

//    int[] tempArr = new int[length];

//    for (int i = 0; i < length; i++)
//    {
//        Console.WriteLine("Enter " + (i + 1) + " number: ");
//        while (!Int32.TryParse(Console.ReadLine(), out tempArr[i]));
//    }

//    return tempArr;
//}

//int[] arr = createArr();
//int[] filterArr = createArr();

//int[] result = filtering(arr, filterArr);

//Console.WriteLine("Array: ");
//printData(arr);

//Console.WriteLine("Filtering array: ");
//printData(filterArr);

//Console.WriteLine("Result: ");
//printData(result);