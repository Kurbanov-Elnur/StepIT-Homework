//int[,] arr = new int[5, 5];
//int inStart1 = 0, inStart2 = 0, inEnd1 = 0, inEnd2 = 0;
//int sum = 0;

//Random random = new Random();

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        arr[i, j] = random.Next(-101, 101);
//    }
//}

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        Console.Write(arr[i,j] + "\t");
//        if (arr[i, j] < arr[inStart1, inStart2])
//        {
//            inStart1 = i;
//            inStart2 = j;
//        }

//        if (arr[i, j] > arr[inEnd1, inEnd2])
//        {
//            inEnd1 = i;
//            inEnd2 = j;
//        }
//    }
//    Console.WriteLine();
//}

//if(inStart1 >= inEnd1)
//{
//    if(inStart1 == inEnd1)
//    {
//        if(inStart2 > inEnd2)
//        {
//            int temp = inStart1;
//            inStart1 = inEnd1;
//            inEnd1 = temp;
//            temp = inStart2;
//            inStart2 = inEnd2;
//            inEnd2 = temp;
//        }
//    }
//    else
//    {
//        int temp = inStart1;
//        inStart1 = inEnd1;
//        inEnd1 = temp;
//        temp = inStart2;
//        inStart2 = inEnd2;
//        inEnd2 = temp;  
//    }
//}

//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        if(i >= inStart1)
//        {
//            if (i == inStart1)
//            {
//                if (j >= inStart2)
//                    sum += arr[i, j];
//            }
//            else
//            {
//                if(i <= inEnd1)
//                {
//                    if(i == inEnd2)
//                    {
//                        if (j <= inEnd2)
//                            sum += arr[i, j];
//                    }
//                }
//            }
//        }
//    }
//}

//Console.WriteLine("Sum in range: " + sum);