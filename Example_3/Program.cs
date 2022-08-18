// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] array = new int [5];
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < array.Length; i++)
{
        array[i] = new Random().Next(0,1000);
    if (array[i] == number) Console.WriteLine("Такое число есть в массиве");
    else Console.WriteLine("Такого числа нет в массиве");
}



Console.WriteLine(array);

// int[] testArray = {-2,-1,0,1,2};
// int searchElement = Convert.ToInt32(Console.ReadLine());

// string foundResult = "не найден"; // false - element not found
// for (int i = 0; i < testArray.Length; i++)
// {
//     if (testArray[i] == searchElement) 
//     {
//         foundResult = "найден"; // element found
//         break;
//     }
// }
// Console.WriteLine($"Элемент {searchElement}: {foundResult}");



// if (foundResult == "найден") Console.WriteLine($"Элемент {searchElement} присутствует ");
//  //foundResult == true => foundResult
// else Console.WriteLine($"Элемент {searchElement} ОТСУТСТВУЕТ ");



// bool testNumber = false;
// if (testNumber) System.Console.WriteLine("true"); // testNumber==true => testNumber
// if(!testNumber) System.Console.WriteLine("false");// !testNumber => testNumber == false
