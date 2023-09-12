//MyArray numbers = new();

//numbers.Add(3);
//numbers.Add(4);
//numbers.Add(5);
//numbers.Add(3);

//Console.WriteLine(numbers.CountDistinct());
//Console.WriteLine(numbers.EqualToValue(4));

//public interface ICalc2
//{
//    int CountDistinct();
//    int EqualToValue(int valueToCompare);
//}


//class MyArray : ICalc2
//{
//    private List<int> Numbers = new();

//    public void Add(int Value)
//    {
//        Numbers.Add(Value);
//    }

//    public void Remove(int value)
//    {
//        Numbers.Remove(value);
//    }

//    public int CountDistinct()
//    {
//        int unique = 0;
//        foreach (int i in Numbers)
//        {
//            int tempUnique = 0;
//            foreach (int j in Numbers) {
//                if(j == i) tempUnique++;
//            }
//            if(tempUnique == 1) unique++;
//        }
//        return unique;
//    }

//    public int EqualToValue(int valueToCompare)
//    {
//        int count = 0;
//        foreach (int item in Numbers)
//        {
//            if(item == valueToCompare) count++;
//        }
//        return count;
//    }
//}