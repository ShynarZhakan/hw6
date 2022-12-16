// Имеется список чисел. Создайте список, в который попадают числа, описывающие максимальную возрастающую последовательность. 
// Порядок элементов менять нельзя.
// Одно число - это не последовательность.

// Пример:
// [1, 5, 2, 3, 4, 6, 1, 7] => [1, 7]
// [1, 5, 2, 3, 4, 1, 7, 8 , 15 , 1 ] => [1, 5]
// [1, 5, 3, 4, 1, 7, 8 , 15 , 1 ] => [3, 5]
int num = new Random().Next(7, 15);
int[] array = new int[num];
FillArray(array);
PrintArray(array);
Console.Write("=> ");
FindMaxSequence(array);

void FindMaxSequence(int[] numbers)
{
    var set = new HashSet<int>(numbers);
    int[] array = set.ToArray();
    Array.Sort(array);
    string[] str = new string[99];
    int counter = 0;
    int stringCount = 0;
    for (int i = 0; i < array.Length - 1; i++)
    {
        str[stringCount] = str[stringCount] + "" + array[i] + ",";
        if (array[i] == array[i + 1] - 1)
        {
            counter++;
            if (i + 1 == array.Length - 1)
            {
                str[stringCount] = str[stringCount] + array[i + 1] + "," + counter;
                stringCount = stringCount + 1;
            }
        }
        else
        {
            str[stringCount] = str[stringCount] + counter;
            stringCount = stringCount + 1;
            counter = 0;
        }
    }
    int max = 0;
    string tempString = "";
    for (int i = 0; i < stringCount; i++)
    {
        if (str[i].Length > 2)
        {
            str[i] = str[i].Remove(str[i].Length - 2);
            if (str[i].Length > max)
            {
                max = str[i].Length;
                tempString = str[i];
            }
        }
    }
    string[] tempStringList = tempString.Split(",");
    Console.WriteLine(tempStringList[0] + "," + tempStringList[tempStringList.Length - 1]);
}

void FillArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 10);

}

void PrintArray(int[] array)
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}