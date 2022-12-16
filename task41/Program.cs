// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int num4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int num5 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] myArray = new int[5] {num1,num2,num3,num4,num5};
PrintArray(myArray);
CheckPositive(myArray);

void PrintArray(int[] arr)
{
    Console.WriteLine("Вывод массива");
    foreach (int el in arr)
    {
       Console.Write (el + " "); 
    }
    
}

void CheckPositive (int[] arr)
{
    int length = arr.Length; 
    int count = 0;
    for (int i = 0; i<length; i++)
    {
        if (arr[i]>0) 
        {
           count++; 
        }
        
    }
    Console.Write(" -> " + count);
}

