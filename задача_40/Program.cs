// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите вершину треугольника");
double A = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите левую сторону треугольника");
double B = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите правую сторону треугольника");
double C = Convert.ToDouble(Console.ReadLine());

double AC = A + C;
double BC = B + C;
double AB = A + B;

if(AB > C & AC > B & BC > A)
{
    Console.WriteLine("Такой треугольник существует");
}
else
{
    Console.WriteLine("Такого треугольника не существует");
}