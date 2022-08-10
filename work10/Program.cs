// Программа: Показывает вторую цифру трехзначного числа

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine()); 
string numberString = number.ToString();
string result = numberString[1].ToString();
Console.WriteLine(result);