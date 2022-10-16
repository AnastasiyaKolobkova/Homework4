// Домашняя работа 4.
// Задача 1.
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int NumberToThePower(int numberA, int numberB)
{
    int result = 1;
    for(int current = 1; current <= numberB; current++)
    {
        result *= numberA; 
    }
    return result;
}

Console.Write("Input a number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int numberToThePower = NumberToThePower(numberA, numberB);
Console.WriteLine("Answer " + numberToThePower);

// Задача 2.
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

  int SumNumber(int number)
  {    
    int count = Convert.ToInt32(number);
    int a = 0;
    int result = 0;
    for (int i = 0; i < count; i++)
    {
      a = number - number % 10;
      result = result + (number - a);
      number = number / 10;
    }
   return result;
  }

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumber = SumNumber(number);
Console.WriteLine("Sum of digits: " + sumNumber);

// Задача 3.
// Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Console.WriteLine("Creating array: ");
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i + 1} element of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Complete!");
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
ShowArray(myArray);