// Задача 35: Задайте одномерный 
// массив из 123 случайных чисел. 
// Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 
// элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] testArray = { -2, -1, 0, 1, 2, 15, 22,99,100 };

int count = 0; // 0 чисел лежат в диапазоне

for (int i = 0; i < testArray.Length; i++) // tesArray.Length - длина массива
{
    if (testArray[i] >= 10 && testArray[i] <= 99) count++; // count = count + 1 
}

System.Console.WriteLine(count);

