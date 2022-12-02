// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Enter a integer: ");
string St = Convert.ToString(Console.ReadLine());

int res = 0;
for(int count = 0; count < St.Length; count++)
    res = res + int.Parse(St[count].ToString());
Console.WriteLine($"Sum digits in the number -> {res}");