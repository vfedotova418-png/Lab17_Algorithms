Console.Write("Введите рост: ");
double height = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите вес: ");
double weight = Convert.ToDouble(Console.ReadLine());
double BMI = weight / (height * height);
if (BMI < 18.5) {
    Console.WriteLine("\nНедостаточный вес");
} else if (18.5 <= BMI && BMI <= 24.9) {
    Console.WriteLine("Нормальный вес");
} else if (25.0 <= BMI && BMI <= 29.9) {
    Console.WriteLine("Избыточный вес");
} else {
    Console.WriteLine("Ожирение");
}
Console.WriteLine("Рекомендация: Заботьтесь о себе и следите за своим здоровьем и ощущением себя в собственном теле");