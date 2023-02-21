// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.WriteLine("Введите значения b1");
double b1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите значения k1");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите значения b2");
double b2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите значения k2");
double k2 = Convert.ToDouble(Console.ReadLine());
double x;
double y;

try {
if(k1 != k2)
{
    x = ((b1 - b2) / (k2 - k1));
    y = k1 * x + b1;
    Console.WriteLine($"Точки пересечения двух прямых [{x}; {y}]");
} 
else if (k1 == k2) System.Console.WriteLine("Прямые совпадают или параллельны"); }
catch {
System.Console.WriteLine("Точек пересечения нет"); }