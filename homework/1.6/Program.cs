// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// // 4 -> да
// // -3 -> нет
// // 7 -> нет

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32 (Console.ReadLine ());
int ost = num % 2;
if (ost == 0)
{
    System.Console.WriteLine($"число {num} четное");
}
else System.Console.WriteLine($"число {num} нечетное");


