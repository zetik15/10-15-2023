Console.WriteLine("Введите число от 1 до 7: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 == 1)
{
    Console.WriteLine("Нет");
}
if (num1 == 2)
{
    Console.WriteLine("Нет");
}
if (num1 == 3)
{
    Console.WriteLine("Нет");
}
if (num1 == 4)
{
    Console.WriteLine("Нет");
}
if (num1 == 5)
{
    Console.WriteLine("Нет");
}
if (num1 == 6)
{
    Console.WriteLine("Да");
}
if (num1 == 7)
{
    Console.WriteLine("Да");
}
else if (num1 < 1 || num1 > 7)
{
    Console.WriteLine("Введите число в заданном диапазоне!");
}