//using System.Text.RegularExpressions;

//class ForeignPassport
//{
//    public string PassportNumber { get; init; }
//    public string Name { get; init; }
//    public string Surname { get; init; }
//    public string Patronomic { get; init; }

//    public ForeignPassport(string _PassportNumber, string _Name, string _Surname, string _Patronomic)
//    {
//        if (int.TryParse(_PassportNumber, out _) || _PassportNumber.Length < 7)
//            throw new Exception("Invalid Passport Number!");
//        if (!Regex.IsMatch(_Name, @"^[a-zA-Z]+$") || _Name.Length < 2 || _Name.Length > 20)
//            throw new Exception("Invalid Name!");
//        if (!Regex.IsMatch(_Surname, @"^[a-zA-Z]+$") || _Name.Length < 2 || _Name.Length > 20)
//            throw new Exception("Invalid Surname!");
//        if (!Regex.IsMatch(_Patronomic, @"^[a-zA-Z]+$") || _Name.Length < 2 || _Name.Length > 20)
//            throw new Exception("Invalid Patronomic!");

//        this.PassportNumber = _PassportNumber;
//        this.Name = _Name;
//        this.Surname = _Surname;
//        this.Patronomic = _Patronomic;
//    }
//}