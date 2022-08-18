// Задача 19. Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int n1 = number / 10000;
// int n2 = (number / 1000) % 10;
// int n4 = (number / 10) % 10;
// int n5 = number % 10;

// if ((n1 == n5) && (n2 == n4))
//      Console.WriteLine($"Число {number} - полиндром");  
// else Console.WriteLine($"Число {number} - не является полиндромом");




// Задача 21. Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите х1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите х2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// √ (x2-x1)^2)+ (y2-y1)^2+ (z2-z1)^2

// double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2-z1, 2));

// Console.WriteLine($"Расстояние между точками: {Math.Round(result, 3)}");





// Задача 23. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= N; i++)
// {
//     Console.Write(Math.Pow(i, 3) + "\t");
// }