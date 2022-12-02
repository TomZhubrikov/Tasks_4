// Дана последовательность из N целых чисел и число K. Необходимо сдвинуть 
// всю последовательность (сдвиг - циклический) на |K| элементов вправо,
// если K – положительное и влево, если отрицательное.

int[] Arr = {8, 1, 6, 2, 5};
int i, c, K = 1;
c = Arr[i];
for (i = Arr.Length - 1; i >= 0; i--) {
    c = Arr[i];
    if (i - K < 0) {
        Arr[i] = c;
    }
    else {
        Arr[i] = Arr[i - K]; ??????????????????????????????????????
    }
}


// Console.Write("Enter a value 'K' -> ");
// int i, c = 0, K = int.Parse(Console.ReadLine());

// if (K > 0) {
//     for (i = 0; i < Arr.Length; i++) {
//         c = 
//     }
// }
// else {
    
// }
Console.Write($"[{string.Join(", ", Arr)}]");