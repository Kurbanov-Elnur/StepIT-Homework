//public class Money
//{
//    public int Dollars { get; private set; }
//    public int Cents { get; private set; }

//    public Money(int dollars, int cents)
//    {
//        Dollars = dollars;
//        Cents = cents;
//    }

//    public void Print()
//    {
//        Console.WriteLine("Money: " + Dollars + '.' + Cents);
//    }

//    public void SetAmount(int dollars, int cents)
//    {
//        Dollars = dollars;
//        Cents = cents;
//    }
//}

//public class Product
//{
//    public string Name { get; private set; }
//    public Money Price { get; }

//    public Product(string name, Money price)
//    {
//        Name = name;
//        Price = price;
//    }

//    public void ReducePrice(int dollars, int cents)
//    {
//        int tempDollar = Price.Dollars;
//        int tempCents = Price.Cents;


//        tempDollar -= dollars;
//        tempCents -= cents;

//        if (tempCents < 0)
//        {
//            tempDollar -= 1;
//            tempCents += 100;
//        }

//        Price.SetAmount(tempDollar, tempCents);
//    }

//    public void AddToPrice(int dollars, int cents)
//    {
//        int tempDollar = Price.Dollars;
//        int tempCents = Price.Cents;

//        tempDollar += dollars;
//        tempCents += cents;

//        if (tempCents >= 100)
//        {
//            tempDollar += tempCents / 100;
//            tempCents %= 100;
//        }

//        Price.SetAmount(tempDollar, tempCents);
//    }
//}