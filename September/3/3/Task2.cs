//Store store = new Store();

//store.InputData();
//Console.WriteLine();
//store.DisplayData();

//class Store
//{
//    public string? Name { get; private set; }
//    public string? Address { get; private set; }
//    public string? Description { get; private set; }
//    public string? Phone { get; private set; }
//    public string? Email { get; private set; }

//    public int StoreAreas { get; set; }

//    public void InputData()
//    {
//        Console.Write("Enter store name: ");
//        Name = Console.ReadLine();

//        Console.Write("Enter store adress: ");
//        Address = Console.ReadLine();

//        Console.Write("Enter store description: ");
//        Description = Console.ReadLine();

//        Console.Write("Enter store contact phone: ");
//        Phone = Console.ReadLine();

//        Console.Write("Enter store contact e-mail: ");
//        Email = Console.ReadLine();
//    }

//    public void DisplayData()
//    {
//        Console.WriteLine("Store name: " + Name);
//        Console.WriteLine("Store adress: " + Address);
//        Console.WriteLine("Store description: " + Description);
//        Console.WriteLine("Store contact phone: " + Phone);
//        Console.WriteLine("Store contact e-mail: " + Email);
//    }

//    public static Store operator +(Store Store, int count)
//    {
//        Store.StoreAreas += count;
//        return Store;
//    }

//    public static Store operator -(Store Store, int count)
//    {
//        Store.StoreAreas -= count;
//        return Store;
//    }

//    public static bool operator >(Store Store1, Store Store2)
//    {
//        return Store1.StoreAreas > Store2.StoreAreas;
//    }

//    public static bool operator <(Store Store1, Store Store2)
//    {
//        return Store1.StoreAreas < Store2.StoreAreas;
//    }

//    public static bool operator ==(Store Store1, Store Store2)
//    {
//        return Store1.Equals(Store2);
//    }

//    public static bool operator !=(Store Store1, Store Store2)
//    {
//        return !Store1.Equals(Store2);
//    }

//    public override bool Equals(object obj)
//    {
//        if (obj is Store)
//        {
//            Store s = obj as Store;
//            return s.Name == Name && s.Address == Address && s.Description == Description && s.Phone == Phone
//                && s.Email == Email && s.StoreAreas == StoreAreas;
//        }

//        return false;
//    }
//}