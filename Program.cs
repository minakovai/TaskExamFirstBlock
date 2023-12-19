// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int CountNewArr(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) count++;
    }
    return count;
}

string[] NewArrayStrings3Char(string[] arr, int count)
{
    string[] newarr = new string[count];
    int ColArray = arr.Length;
    int j = 0;
    for (int i = 0; i < ColArray; i++)
    {
        if (arr[i].Length <= 3)
        {
            newarr[j] = arr[i];
            j++;
        }
    }
    return newarr;

}

// Инициализируем массив
string[] strArray = new string[] { "Hello", "2", "world", ":-)", "Test" };
PrintArray(strArray);
int countNewarr = CountNewArr(strArray);
string[] newArray = NewArrayStrings3Char(strArray,countNewarr);
PrintArray(newArray);
