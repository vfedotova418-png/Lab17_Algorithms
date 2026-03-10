double Sum(double a, double b) {
    return a + b;
}

double Sub(double a, double b) {
    return a - b;
}

double Mul(double a, double b) {
    return a * b;
}

double Div(double a, double b) {
    return a / b;
}

double num1 = Convert.ToDouble(Console.ReadLine());
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\nРезультаты");
Console.WriteLine($"{num1} + {num2} = {Sum(num1, num2)}");
Console.WriteLine($"{num1} - {num2} = {Sub(num1, num2)}");
Console.WriteLine($"{num1} * {num2} = {Mul(num1, num2)}");
Console.WriteLine($"{num1} / {num2} = {Div(num1, num2)}");