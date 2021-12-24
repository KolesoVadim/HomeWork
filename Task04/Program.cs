// Показать последнюю цифру трёхзначного числа.
Console.Write("Ведите трёхзначное число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int lastN = number % 10;
Console.WriteLine("Последняя цифра трёхзначного числа: " + lastN);