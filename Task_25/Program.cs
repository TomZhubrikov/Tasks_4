// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// НЕ ИСПОЛЬЗОВАТЬ Math.Pow

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Enter a number: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Enter a degree: ");
int d = int.Parse(Console.ReadLine());

int i, res = 1;
for (i = 0; i < d; i++) {
    res = res * n;
}

Console.WriteLine($"Rasult -> {res}");