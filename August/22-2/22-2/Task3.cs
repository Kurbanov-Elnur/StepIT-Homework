//Console.Write("Enter text: ");
//string text = Console.ReadLine(), newText = "";

//int shift = 0;
//bool checkoutNumber = false;

//while (!checkoutNumber)
//{
//    Console.Write("Enter shift: ");
//    checkoutNumber = Int32.TryParse(Console.ReadLine(), out shift);
//}

//string textToEncrypted(string text, string newText, int shift)
//{
//    for (int i = 0; i < text.Length; i++)
//    {
//        int letter = (int)text[i] + shift;
//        newText += (char)letter;
//    }
//    return newText;
//}

//string encryptedToText(string text, string newText, int shift)
//{
//    for (int i = 0; i < text.Length; i++)
//    {
//        int letter = (int)text[i] - shift;
//        newText += (char)letter;
//    }
//    return newText;
//}

//int choice = 0;

//checkoutNumber = false;
//Console.WriteLine("1. Text to Encrypted \n" +
//    "2. Encrypted to Text");

//while (!checkoutNumber || choice <= 0 || choice > 2)
//{
//    Console.Write("Enter your choice: ");
//    checkoutNumber = Int32.TryParse(Console.ReadLine(), out shift);
//}

//switch (choice)
//{
//    case 1:
//        textToEncrypted(text, newText, shift);
//        Console.WriteLine("Encypted text: " + newText);
//        break;
//    case 2:
//        encryptedToText(text, newText, shift);
//        Console.WriteLine("Text: " + newText);
//        break;
//}