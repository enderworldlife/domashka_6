


// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.
using System.Runtime.InteropServices.Marshalling;

void PrintStringArray(string[] newstr){
    int length = newstr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(newstr[i] + " ");
        if (i == length){
            Console.WriteLine(" ");
        }
    }
    Console.WriteLine();

}

char[,] newchar = new char[,] {
    {'P','r','i','v'},
    {'1','2','3','4'}
};

string[] PrintFromCharToStringOf2DMassiv (char[,] newchar){
    string[] newstring = new string[newchar.GetLength(0)];
    
    for (int i = 0; i < newchar.GetLength(0); i++)
    {
        string astring = string.Empty;
        for (int j = 0; j < newchar.GetLength(1); j++)
        {   
            astring = astring + newchar[i,j];
        }
        newstring[i] = astring;   
    }
    return newstring;
}

string[] gotnewstring = PrintFromCharToStringOf2DMassiv(newchar);
PrintStringArray(gotnewstring);

