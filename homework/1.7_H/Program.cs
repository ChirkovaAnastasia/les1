// Задача 7 HARD по желанию - Напишите программу, которая принимает на вход целое число
//  любой разрядности и на выходе показывает третью цифру слева этого числа или говорит,
//  что такой цифры нет. Через строку решать нельзя.
// 456111 -> 6
// // 78 -> нет
// // 9146548 -> 4
// // 3 -> нет

System.Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int ThirdDigit;
int result;

    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
         result = number % 10;
         System.Console.Write (result);
    }
    else
    {
        System.Console.Write ("число не имеет третьей цифры");
    }

  
