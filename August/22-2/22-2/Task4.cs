//void enterData(out int[,] matrix1, out int[,] matrix2, out int row, out int col)
//{
//    Console.Write("Enter row: ");
//    Int32.TryParse(Console.ReadLine(), out row);

//    Console.Write("Enter col: ");
//    Int32.TryParse(Console.ReadLine(), out col);
//    matrix1 = new int[row, col];
//    matrix2 = new int[row, col];

//    for (int i = 0; i < row; i++)
//    {
//        for (int j = 0; j < col; j++)
//        {
//            Console.Write("Enter a number by index for matrix 1 " + (i + 1) + ':' + (j + 1) + ": ");
//            Int32.TryParse(Console.ReadLine(), out matrix1[i,j]);

//            Console.Write("Enter a number by index for matrix 2 " + (i + 1) + ':' + (j + 1) + ": ");
//            Int32.TryParse(Console.ReadLine(), out matrix2[i, j]);
//        }
//    }
//}

//void printData(int[,] matrix, int row, int col)
//{
//    for (int i = 0; i < row; i++)
//    {
//        for (int j = 0; j < col; j++)
//        {
//            Console.Write(matrix[i, j] + "\t");
//        }
//        Console.WriteLine();
//    }
//}

//int choice = 0, row, col;
//int[,] matrix1, matrix2;

//enterData(out matrix1, out matrix2, out row, out col);

//bool checkoutNumber = false;

//Console.WriteLine("1. Multiplying a matrix by a number \n" +
//    "2. Matrix Addition \n" +
//    "3. Product of matrices");

//while (!checkoutNumber || choice <= 0 || choice > 3)
//{
//    Console.Write("Enter your choice: ");
//    checkoutNumber = Int32.TryParse(Console.ReadLine(), out choice);
//}

//if(choice == 1)
//{
//    int multiplier = 0;
//    Console.Write("Enter multiplier: ");
//    Int32.TryParse(Console.ReadLine(), out multiplier);

//    Console.WriteLine("Arrays before: ");
//    printData(matrix1, row, col);
//    printData(matrix2, row, col);

//    for (int i = 0; i < row; i++)
//    {
//        for (int j = 0; j < col; j++)
//        {
//            matrix1[i, j] *= multiplier;
//            matrix2[i, j] *= multiplier;
//        }
//    }

//    Console.WriteLine("Arrays after: ");
//    printData(matrix1, row, col);
//    printData(matrix2, row, col);
//}
//else if(choice == 2)
//{
//    int[,] result = new int[row, col];

//    for (int i = 0; i < row; i++)
//    {
//        for (int j = 0; j < col; j++)
//        {
//            result[i, j] = matrix1[i, j] + matrix2[i, j];
//        }
//    }

//    Console.WriteLine("Matrix Addition: ");
//    printData(result, row, col);
//}
//else
//{
//    int[,] result = new int[row, col];

//    for (int i = 0; i < row; i++)
//    {
//        for (int j = 0; j < col; j++)
//        {
//            result[i, j] = matrix1[i, j] * matrix2[i, j];
//        }
//    }

//    Console.WriteLine("Matrix product: ");
//    printData(result, row, col);
//}