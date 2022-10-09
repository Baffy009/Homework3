// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

    Console.Clear();
    Console.Write ("Введите число: ");
    int num = Math.Abs (int.Parse (Console.ReadLine() ?? "0"));
    
    for (int i = 1; i <= num; i++)
    {
        double cube = Math.Pow (i, 3);
        if (i == num) Console.WriteLine(cube);
        else
        {
            Console.WriteLine(cube + ", ");
        }
    }