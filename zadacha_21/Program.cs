//Задача 21 Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите точку А");

Console.WriteLine("Введите координату x:");
int ax = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату y:");
int ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату z:");
int az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите точку B");

Console.WriteLine("Введите координату x:");
int bx = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату y:");
int by = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату z:");
int bz = Convert.ToInt32(Console.ReadLine());

double R = Math.Sqrt(
    Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2)
    );

Console.WriteLine("Расстояние между точками=" + Math.Round(R, 2));

