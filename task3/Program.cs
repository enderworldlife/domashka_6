
void PrintNewChar(char[] newchar){
    for (int i = 0; i < newchar.Length; i++){
        Console.Write(newchar[i] + " ");
        }
    Console.WriteLine();
}
Console.Write("Введите слово радар или что то другое: ");
string astring1 = Console.ReadLine();
char[] FromAStringToNewChar (string astring){
    int length = astring.Length;
    char[] newchar = new char[length];
    for (int i = 0; i < length; i++)
    {
        newchar[i] = astring[i];
    }
    return newchar;
}
string FromNewCharToAString (char[] newchar){
    string astring = string.Empty;
    for (int i = 0; i < newchar.Length; i++)
    {
        astring = astring + newchar[i];
    }
    return astring;
}
char[] ReverseNewChar (char[] newchar){
    char[] newreversedchar = new char[newchar.Length];
    for (int i = 0, j = newchar.Length - 1; i < newchar.Length; i++, j--)
    {
            newreversedchar[i] = newchar[j];
        
    }
    return newreversedchar;
}
bool IsPalindrom (string astring, string areversedstring){
    bool isPalindrom = false;
    if (astring == areversedstring){
        isPalindrom = true;
    }
    return isPalindrom;    
}

Console.WriteLine();
char[] newgottenchar = FromAStringToNewChar(astring1);
Console.Write("Слово: ");
PrintNewChar(newgottenchar);
Console.WriteLine();
char[] newreversedchar = ReverseNewChar(newgottenchar);
Console.Write("Реверснутое слово: ");
PrintNewChar(newreversedchar);
Console.WriteLine();
string astringedstring = FromNewCharToAString(newgottenchar);
string areversedstring = FromNewCharToAString(newreversedchar);
bool isPalindrom= IsPalindrom(astringedstring, areversedstring);

if (isPalindrom == false){
    Console.WriteLine("Слово '" + astringedstring + "' не палиндромное. ");
}
else if (isPalindrom == true){
    Console.WriteLine($"Слово '"+ areversedstring + "' палиндромное. ");
}




