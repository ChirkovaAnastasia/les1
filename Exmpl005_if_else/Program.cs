﻿Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("УРА, ЭТО ЖЕ МАША!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
    }