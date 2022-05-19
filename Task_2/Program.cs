// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int summ(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}


Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(summ(number));