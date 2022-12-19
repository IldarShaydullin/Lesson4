// программа просит ввести число пользователя и считает сумму всех чисел от 1 до заданного числа.
/*
int GetSum(int num)
{
    int sum = 0;

    for(int current = 1; current <= num; current++)
    {
        sum = sum + current;
    }
    return sum;
}

Console.Write("Input a number : ");
int a = Convert.ToInt32(Console.ReadLine());

int result = GetSum(a);
Console.WriteLine($"Sum of numbers from 1 to {a} is {result}");
*/

// Программа принимает на вход число и выводит кол-во цифр в данном числе.

/*
int Quantity(int number)
{
    int count = 1;
    while(number >= count)
    {
        number = number / 10;
        count++;
    }
   
    return  count;
}

Console.Write("Input a number : ");
int num = Convert.ToInt32(Console.ReadLine());

int result = Quantity(num);
Console.WriteLine($"The number of digits in the number {num} is equal to {result}");
*/

// Напишите программу которая принимает на вход число N и выдает произведения чисел от 1 до N
/*

int Factorial(int num)
{
    int factor = 1;

    for(int count = 0; count <= num; count++)
    {
        factor = count * factor;

    }
    return factor;
}
Console.Write("Input a number : ");
int number = Convert.ToInt32(Console.ReadLine());

int result = Factorial(number);
Console.WriteLine(result);
*/
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int [size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) 
    {
        Console.Write(array[i] + " ");
    }
}

Console.Write("Input a number of elements : ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value : ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value : ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);  
*/


// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*

int Degree(int a, int b)
{
    int result = a;
    for(int count = 1; count < b; count++)
    {
       result = result * a;

    }
    return result;

}

Console.Write("Input a number 1 : ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number 2 : ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = Degree(num1, num2);
Console.WriteLine(result);

*/

//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int Summ(int number)
{
     int sum = 0;
   while(number > 0)
   {
    int newnumber = number;
    sum = sum + newnumber % 10;  
    number = number / 10; 
   }
   return sum;
}

Console.Write("Input a number : ");
int num = Convert.ToInt32(Console.ReadLine());

int result = Summ(num);
Console.WriteLine(result);
*/

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*

int[] CreateArray(int a, int b, int c, int d, int e, int f, int g, int h)
{
    int size = 8;
    int[] array = new int [size];

    for(int i = 0; i < size; i++)
    {
        array[i] = a;
        a = b; b = c; c = d; d = e; e = f; f = g; g = h;

    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) 
    {
        Console.Write($"{array[i]} ");
    }
}


Console.Write("Input 1 number array : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 2 number array : ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 3 number array : ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 4 number array : ");
int d = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 5 number array : ");
int e = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 6 number array : ");
int f = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 7 number array : ");
int g = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 8 number array : ");
int h = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(a, b, c, d, e, f, g, h);
ShowArray(myArray);  
*/