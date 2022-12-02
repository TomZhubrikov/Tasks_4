// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, запрашивает данные(элементы массива) у пользователя и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Enter values an array[8].");
int n;
int[] Arr = new int[8];

// Заполнение массива
for (int count = 0; count < 8; count++) {
    Console.Write($"Enter value {count + 1} element -> ");
    Arr[count] = int.Parse(Console.ReadLine());
}
// Вывод массива
Console.Write($"[{string.Join(", ", Arr)}]");

