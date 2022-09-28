//Задача 23 Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());

int counter = 1;

while (counter <= number) {
    double result = Math.Pow(counter, 3);
    if (counter < number) Console.Write(result + ", ");
    else Console.WriteLine(result);
    counter++;
}

