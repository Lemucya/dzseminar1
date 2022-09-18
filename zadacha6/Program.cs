// Напишите программу, которая на вход принимает число и выдает, является ля число четным (делится ли оно на два без остатка)
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 1)
{
    Console.WriteLine("Нет, число " + number + " является нечетным");
}
else
{
    Console.WriteLine("Да, число " + number + " является четным");
}