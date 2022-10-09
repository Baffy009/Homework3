// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

    Console.Clear();
    Console.Write ("Введите координаты x1: ");
    int x1 = int.Parse (Console.ReadLine() ?? "0");
    Console.Write("Введите координаты y1: ");
    int y1 = int.Parse (Console.ReadLine() ?? "0");
    Console.Write("Введите координаты z1: ");
    int z1 = int.Parse (Console.ReadLine() ?? "0");
    Console.Write("Введите координаты x2: ");
    int x2 = int.Parse (Console.ReadLine() ?? "0");
    Console.Write("Введите координаты y2: ");
    int y2 = int.Parse (Console.ReadLine() ?? "0");
    Console.Write("Введите координаты z2: ");
    int z2 = int.Parse (Console.ReadLine() ?? "0");

    double dist = Math.Round (Math.Sqrt (Math.Pow ((x2 - x1), 2) + Math.Pow ((y2 - y1), 2) + Math.Pow ((z2 - z1), 2)), 2);
    Console.WriteLine("Расстояние между точками: " + dist);