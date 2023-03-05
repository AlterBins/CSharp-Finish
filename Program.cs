string[] arr =  {"win","hand",
    "oops", "136", "men", "weight",
    "bag", "lamp", "fish", "sun",
    "GB","rofl","too"};

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

void PrintArraySorting(string[] sortingArray)
{
    for (int i = 0; i < sortingArray.Length; i++)
    {
        Console.Write(sortingArray[i] + " ");
    }
}

string[] SortingArray(string[] array)
{
    string[] sortingArray = new string[array.Length];
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            sortingArray[temp] = array[i];
            temp++;
        }
    }
    return sortingArray;
}

Console.WriteLine("Первоначальный массив: ");
PrintArray(arr);
Console.WriteLine("Полученный массив: ");
string[] sortingArray = SortingArray(arr);
PrintArraySorting(sortingArray);