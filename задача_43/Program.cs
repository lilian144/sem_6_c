// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;  k1 = k2- параллельны 
// значения b1, k1, b2 и k2 задаются пользователем.  
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите начало пересечения первой прямой");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите конец пересечения первой прямой");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите начало пересечения второй прямой");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите конец пересечения второй прямой");
double k2 = Convert.ToDouble(Console.ReadLine());


if(k1 == k2)
{
    Console.WriteLine("Прямые параллельны и не пересекаются");
}
else
{
    double x= (b2 - b1)/(k1 - k2);
    double y = k2 * x + b2;
    Console.WriteLine($"({x} ; {y})");
}