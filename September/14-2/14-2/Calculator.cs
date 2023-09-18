MathOperation operation = Calculator.Add;

Console.WriteLine(Calculator.Calculate(operation, 3, 4));

operation = Calculator.Subtract;

Console.WriteLine(Calculator.Calculate(operation, 8, 5));

operation = Calculator.Multiply;

Console.WriteLine(Calculator.Calculate(operation, 3, 3));

operation = Calculator.Divide;

Console.WriteLine(Calculator.Calculate(operation, 6, 2));

delegate double MathOperation(double FirstNumber, double SecondNumber);

class Calculator
{    
    public static double Add(double FirstNumber, double SecondNumber)
    {
        return FirstNumber + SecondNumber;
    }

    public static double Subtract(double FirstNumber, double SecondNumber)
    {
        return FirstNumber - SecondNumber; 
    }

    public static double Multiply(double FirstNumber, double SecondNumber)
    {
        return FirstNumber * SecondNumber;
    }

    public static double Divide(double FirstNumber, double SecondNumber)
    {
        return FirstNumber / SecondNumber;
    }

    public static double Calculate(MathOperation Operation, double FirstNumber, double SecondNumber)
    {
        return Operation(FirstNumber, SecondNumber);
    }
}