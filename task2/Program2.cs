
// Задача 2: Задайте строку, содержащую латинские 
// буквы в обоих регистрах. 
// Сформируйте строку, в которой все 
// заглавные буквы заменены на строчные.


// Простите я не совсем понял задачу и надеюсь я сделал правильно. Спасибо!

string astring = "Hello World";

string LowString (string str){
    string lowedastring = string.Empty;
    lowedastring = str.ToLower();
    return lowedastring;
}

string lowedastring = LowString(astring);
Console.WriteLine(lowedastring);
