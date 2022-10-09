// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
int InputIntNumber()
{
    while (true)
    {
        Console.Write("Введите пятизначное число: ");
        int number = int.Parse(Console.ReadLine() ?? "0");
        while (number > 9999 && number < 100000)
            return number;
    }
    
}

int num = InputIntNumber();
    string chars = num.ToString();
    if (chars[0] == chars[4] && chars[1] == chars[3])
    {
        Console.WriteLine("Да ");
    }
    else
    {
        Console.WriteLine("Нет ");
    }
;