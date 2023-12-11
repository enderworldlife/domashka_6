// // Задача 4*(не обязательная): 
// // Задайте строку, состоящую из слов, 
// // разделенных пробелами. 
// // Сформировать строку, в которой 
// // слова расположены в обратном порядке. 
// // В полученной строке слова должны 
// // быть также разделены пробелами.

// string astring = "мама папа бабушка дедушка сестра брат дядя тетя";

// void PrintNewString(string[] newstring){
//     for (int i = 0; i < newstring.Length; i++)
//     {
//         Console.Write(newstring[i] + " ");
//     }
// }

// string[] FromAstringToNewString(string astring){
//     int length = astring.Length;
//     int spacecount = 0;
//     string[] newstring = new string[length];
//     for (int i = 0; i < length; i++){
//         string tempstring = string.Empty;
//         while (astring[i] != ' '){
//             tempstring = tempstring + astring[i];
//             i++;
//             newstring[spacecount] = tempstring;
//         }
//         while(astring[i] == ' '){
//             spacecount++;
//             i++;
//         }
//     }
//     return newstring;
// }

// string[] newstring = FromAstringToNewString(astring);
// Console.WriteLine(newstring);


static void PrintStringArray(string[] newstr)
{
    int length = newstr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(newstr[i] + " ");
    }
    Console.WriteLine();
}

static string[] SplitAStringToNewString(string strings)
{
    int stringsLength = strings.Length;
    string[] newstrings = new string[strings.Length]; 
    int j = 0;
    for (int i = 0; i < stringsLength; i++)
    {
        while (i < stringsLength && strings[i] == ' ')
        {
            i++;
        }

        while (i < stringsLength && strings[i] != ' ')
        {
            newstrings[j] += strings[i];
            i++;
        }
        j++;
    }
    return newstrings;
}


string strings = "Мама Папа Сестра Брат Дедушка Бабушка Дядя Тетя";
string[] splitedStrings = SplitAStringToNewString(strings);
PrintStringArray(splitedStrings);



