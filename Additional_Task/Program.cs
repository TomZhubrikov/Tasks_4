// Дана последовательность из N целых чисел и число K. Необходимо сдвинуть 
// всю последовательность (сдвиг - циклический) на |K| элементов вправо,
// если K – положительное и влево, если отрицательное.

int[] Arr = {8, 1, 6, 2, 5};
int[] help_arr = new int[5];

Console.Write("Enter a value 'K' -> ");
int i, K = int.Parse(Console.ReadLine());

if (K > 0) {
    for (i = 0; i < Arr.Length; i++) {
        if (i - K < 0) 
            help_arr[i] = Arr[Arr.Length + i - K];
        else 
            help_arr[i] = Arr[i - K];
    }
}
else {
    for (i = 0; i < Arr.Length; i++) {
        if (i + Math.Abs(K) > Arr.Length - 1) 
            help_arr[i] = Arr[i + Math.Abs(K) - Arr.Length];
        else 
            help_arr[i] = Arr[i + Math.Abs(K)];
    }
}

Console.Write($"[{string.Join(", ", help_arr)}]");