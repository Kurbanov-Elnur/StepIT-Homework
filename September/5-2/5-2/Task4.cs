//abstract class Worker
//{
//    public string Name { get; init; }
//    public string Responsibilities { get; init; }

//    public Worker(string name, string responsibilities)
//    {
//        Name = name;
//        Responsibilities = responsibilities;
//    }

//    public abstract void Print();
//}

//class President : Worker
//{
//    public President(string name, string responsibilities) : base(name, responsibilities) { }

//    public override void Print()
//    {
//        Console.WriteLine("President: " + Name);

//        Console.WriteLine("Responsibilities: \n" + Responsibilities);
//    }
//}

//class Guard : Worker
//{
//    public Guard(string name, string responsibilities) : base(name, responsibilities) { }

//    public override void Print()
//    {
//        Console.WriteLine("Guard: " + Name);

//        Console.WriteLine("Responsibilities: \n" + Responsibilities);
//    }
//}

//class Manager : Worker
//{
//    public Manager(string name, string responsibilities) : base(name, responsibilities) { }

//    public override void Print()
//    {
//        Console.WriteLine("Manager: " + Name);
   
//        Console.WriteLine("Responsibilities: \n" + Responsibilities);
//    }
//}

//class Engineer : Worker
//{
//    public Engineer(string name, string responsibilities) : base(name, responsibilities)
//    {
//    }

//    public override void Print()
//    {
//        Console.WriteLine("Engineer: " + Name);

//        Console.WriteLine("Responsibilities: \n" + Responsibilities);
//    }
//}