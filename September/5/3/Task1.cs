//Journal journal = new Journal();

//journal.inputData();
//Console.WriteLine();
//journal.printData();

//class Journal
//{
//    public string? name { get; private set; }
//    public int yearFounded { get; private set; }
//    public string? description { get; private set; }
//    public string? phone { get; private set; }
//    public string? email { get; private set; }
//    public int NumberOfEmployees { get; private set; }

//    public void inputData()
//    {
//        Console.Write("Enter journal name: ");
//        name = Console.ReadLine();

//        Console.Write("Enter journal year founded: ");
//        yearFounded = int.Parse(Console.ReadLine());

//        Console.Write("Enter journal description: ");
//        description = Console.ReadLine();

//        Console.Write("Enter contact phone: ");
//        phone = Console.ReadLine();

//        Console.Write("Enter contact e-mail: ");
//        email = Console.ReadLine();

//        Console.WriteLine("Enter number of Employees: ");
//        NumberOfEmployees = int.Parse(Console.ReadLine());
//    }

//    public void printData()
//    {
//        Console.WriteLine("Journal name: " + name);
//        Console.WriteLine("Journal year founded: " + yearFounded);
//        Console.WriteLine("Journal description: " + description);
//        Console.WriteLine("Journal contact phone: " + phone);
//        Console.WriteLine("Journal contact e-mail: " + email);
//        Console.WriteLine("Journal number of employees " + NumberOfEmployees);
//    }

//    public static Journal operator +(Journal journal1, int count)
//    {
//        journal1.NumberOfEmployees += count;
//        return journal1;
//    }

//    public static Journal operator -(Journal journal1, int count)
//    {
//        journal1.NumberOfEmployees -= count;
//        return journal1;
//    }

//    public static bool operator >(Journal journal1, Journal journal2)
//    {
//        return journal1.NumberOfEmployees > journal2.NumberOfEmployees;
//    }

//    public static bool operator <(Journal journal1, Journal journal2)
//    {
//        return journal1.NumberOfEmployees < journal2.NumberOfEmployees;
//    }

//    public static bool operator ==(Journal journal1, Journal journal2)
//    {
//        return journal1.Equals(journal2);
//    }

//    public static bool operator !=(Journal journal1, Journal journal2)
//    {
//        return !journal1.Equals(journal2);
//    }

//    public override bool Equals(object obj)
//    {
//        if (obj is Journal) 
//        {
//            Journal j = obj as Journal;
//            return j.name == name && j.yearFounded == yearFounded && j.description == description && j.phone == phone
//                && j.email == email && j.NumberOfEmployees == NumberOfEmployees;
//        }

//        return false;
//    }
//}