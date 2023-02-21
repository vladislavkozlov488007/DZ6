// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
// ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2; 1, -7, 567, 89, 223-> 3;

System.Console.WriteLine("Введите размер массива");
int[] array = new int [Convert.ToInt32(Console.ReadLine())];
int count = 0;
for (int i=0; i<array.Length; i++)
    {
        System.Console.WriteLine("Введите числа");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0) count++;
    }

System.Console.Write($"Количество положительных чисел равно {count}");

