﻿// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// **Примеры**:

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

// ["1234", "1567", "-2", "computer science"] -> ["-2"]

// ["Russia", "Denmark", "Kazan"] -> []


string[] arrayString = new string[] {"summer", "spring", "autumn", "sun", "day", "may", "15", "255324", "GB"};

string FindLenght(string[] array)
{
	int size = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i].Length <= 3)
		{
			size++;
		}
	}
	return Convert.ToString(size);
}

int lenghthArr = Convert.ToInt16(FindLenght(arrayString));

string[] newArray = new string[lenghthArr];

string[] FillArray(string[] arrOne, string[] arrTwo)
{
	int index = 0;
	for (int i = 0; i < arrOne.Length; i++)
	{
		if(arrOne[i].Length <= 3)
		{
			arrTwo[index] = arrOne[i];
			index++;
		}
	}
	return arrTwo;
}

newArray = FillArray(arrayString, newArray);

void PrintArray(string[] arr)
{
	int i = 0;
	Console.Write($"[");
	while(i < arr.Length - 1)
	{
		Console.Write($"\"{arr[i]}\", ");
		i++;
	}
	Console.Write($"\"{arr[i]}\"]");
}
PrintArray(newArray);

// string[] arrayString = new string[] {"summer", "spring", "autumn", "sun", "day"};

// var result = new string[arrayString.Length];
// var realSize = 0;
// for (int i = 0; i < arrayString.Length; i++)
// {
// 	if(arrayString[i].Length <= 3)
// 	{
// 		result[realSize] = arrayString[i];
// 		Console.Write($"{result[realSize]}, ");
// 		realSize++;
// 	}
// }