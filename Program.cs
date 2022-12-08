int a;
int b;
int min;
int max;

Console.Write($"Введите первое число ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"Введите второе число ");
int.TryParse(Console.ReadLine()!, out b);

if (a>b)
{
    max=a;
    min=b;
    Console.Write($"Максимальное число {a} ");
    Console.Write($"Минимальное число {b} ");
}

else {
    max=b;
    min=a;
     Console.Write($"Максимальное число {b} ");
     Console.Write($"Минимальное число {a} ");
}

