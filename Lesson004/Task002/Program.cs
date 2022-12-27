// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите число: ");
int number= Convert.ToInt32(Console.ReadLine());

int length = Numbers(number);
SumNumbers(number, length);

int Numbers(int a) 
{
int index = 0;
while (a > 0)
    {
        a /= 10;
        index++;
    }
return index;
}

void SumNumbers(int n, int length )
{
int sum = 0;
for (int i = 1; i <= length; i++)
    {
    sum += n % 10;
    n /= 10;
    }
Console.Write($"Сумма цифр в числе равна {sum}");
}

