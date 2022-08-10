// Программа: Выводит третью цифру заданного числа

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberString = number.ToString();
if (number > 99)
{
    string result = numberString[2].ToString();
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

