// Найти третью цифру числа или сообщить, что её нет.
Console.Write("Введите число: ");
string str = Console.ReadLine();
 if(str.Length >= 3)
 {
     Console.WriteLine(str[2]);
 }
 else
 {
     Console.WriteLine("Третьей цифры нет");
 }