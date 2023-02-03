/*
Итоговая проверочная работа

Задача:
Написать программу, которая из имеющегося массива строк
формирует массив из строк, длина которых меньше либо равна 3 символа.

Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма.

При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.*
*/




using static System.Console;

Clear();

string[] array = inputArray();
string[] result = FindLess(array, 3);
WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
WriteLine($"Итоговый массив: [{string.Join(", ", result)}]");

string[] FindLess(string[] input, int x)
{
    string[] output = new string[CountLess(input, x)];

    for(int i = 0, j = 0; i < input.Length; i++)
    {
        if(input[i].Length <= x)
        {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int CountLess(string[] input, int x)
{
    int count = 0;

    for(int i = 0; i < input.Length; i++)
    {
        if(input[i].Length <= x)
        {
            count++;
        }
    }

    return count;
}

string[] inputArray()
{
    Write("Введите элементы начального массива через пробел: ");
    return ReadLine().Split(" ");
}