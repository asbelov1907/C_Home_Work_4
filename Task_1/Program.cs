// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число А:");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B:");
int numberB = int.Parse(Console.ReadLine());
int result = NatureDegree(numberA, numberB);
Console.WriteLine(result);





int NatureDegree(int numA, int numB)
{
    int Degree = numberA;
    for (int i = 1; i < numberB; i++)
    {
        Degree = Degree*numberA;
        
    }
    return Degree;
}


