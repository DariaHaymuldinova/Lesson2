// Программа: принимает на вход цифру обозначающую день недели и проверяет является ли этот день выходным

Console.WriteLine("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine()); 
if ((number > 5) && (number < 8))
{
    Console.WriteLine("да");
}

else if (number > 7)
{
    Console.WriteLine("Такого дня недели не существует");
}

else
{
    Console.WriteLine("нет");
}
Console.ReadLine();