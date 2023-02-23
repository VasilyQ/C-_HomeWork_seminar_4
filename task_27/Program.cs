// Задача 27: Напишите программу, которая принимает на вход число и
//  выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int ReadNumber(string MessageNumber)
{
    Console.WriteLine(MessageNumber);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int ResultNumber(int result)
{
    int number = 0;
    while(result != 0)
    {
        int count = result;
        count = count % 10;
        number = number + count;
        result = result / 10;
    }
    return number;
}

int sum = ResultNumber(ReadNumber("Введите число"));
Console.WriteLine(sum);
