Random rnd = new Random();
int number = rnd.Next(1, 101);
Console.WriteLine("Компьютер загадал случайное число от 1 до 100");
int attempts = 1;

while (true)
{
    Console.Write("Введите ваше предположение: ");
    if (!int.TryParse(Console.ReadLine(), out int guess))
    {
        Console.WriteLine("Ошибка! Введите целое число.");
        continue;
    }
    if (guess == number)
    {
        Console.WriteLine("\nВерно! Вы угадали.");
        break;
    }
    else if (guess > number)
    {
        Console.WriteLine("\nНеверно! Загадданное число меньше.\nПопробуйте ещё раз.");
        attempts += 1;
    }
    else if (guess < number)
    {
        Console.WriteLine("\nНеверно! Загадданное число больше.\nПопробуйте ещё раз.");
        attempts += 1;
    }
}
Console.WriteLine($"Статистика: {attempts} попыток ушло на отгадывание числа {number}!");