Console.WriteLine("Введите трехзначное число: ");
int num1 = Convert.ToInt32 (Console.ReadLine());
if (num1 >= 100 && num1 < 1000)
{
    int result = (num1 % 100) / 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Введите трехзначное число!");
}