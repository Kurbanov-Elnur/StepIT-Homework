//Console.Write("Enter text: ");
//string text = Console.ReadLine(), newText = "";
//Console.Write("Enter an invalid word: ");
//string word = Console.ReadLine();
//int statistics = 0; 

//for (int i = 0; i < text.Length; i++)
//{
//    if (text[i] == word[0] && text[i - 1] == ' ')
//    {
//        string word2 = "";
//        for (int j = 0; j < word.Length; j++)
//        {
//            word2 += text[i];
//            i++;
//        }
//        if (i < text.Length && (int)text[i] >=  32 && (int)text[i] <= 47)
//        {
//            for (int k = 0; k < word.Length; k++)
//            {
//                newText += '*';
//            }
//            newText += ' ';
//            statistics++;
//        }
//    }
//    else
//        newText += text[i];
//}

//Console.WriteLine("Result: \n" + newText);
//Console.WriteLine("Statistics: " + statistics + " word replacements " + word);