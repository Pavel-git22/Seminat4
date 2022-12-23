// //Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// int FindSum (int num)
// {
//     int sum = 0;
//     for(int current= 1; current<=num;current++)
//     {
//         sum += current;
//     }
//     return sum;
// }

// Console.WriteLine("Input A:");
// int a = Convert.ToInt32(Console.ReadLine());
// int result = FindSum(a);
// Console.WriteLine(result);

//Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

//456 -> 3
//78 -> 2
//89126 -> 5

// string str = "123";
// int a1 = str.Length;
// Console.WriteLine(a1);


//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

//4  -> 24
//5  -> 120


// Console.WriteLine(" Введите число а:  ");
// int a = Convert.ToInt32(Console.ReadLine());
// int i=1;
// int f = 1;
// while  (i<=a)
// {
//     f = f*i;
//     i++;
// }
// Console.WriteLine($" Введите число {f} ");



//Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]



// int[] CreateRandomArray (int size,int minValue, int maxValue)
// {
//     int[] myArray = new int[size];
//     for(int i=0;i<size;i++)
//     {
//         myArray[i] = new Random().Next(minValue,maxValue+1);
//     }
//     return myArray;
// }

// void ShowArray (int[] array)
// {
//     Console.WriteLine("Полученный массив ->:");
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]+" ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());

// // int[] newArray = CreateRandomArray(lenght,min,max);
// // ShowArray(newArray);

// ShowArray(CreateRandomArray(lenght,min,max));


// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// // 3, 5 -> 243 (3⁵)

// // 2, 4 -> 16



// Console.Write(" Введите число :  ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write(" Введите степень числа :  ");
// int stp = Convert.ToInt32(Console.ReadLine());


// int QQ1 (int x, int y)
// {
//     int z = 1;
//     int i = 0;
//     while (i < y)
//     {
//         z = z * x;
//         i++;
//     }
//     return z;
// }
// int N = QQ1(A, stp);
// Console.WriteLine($"число {A} в степени {stp} = {N}" );
// Console.Write("________________________________________________");


// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// // 452 -> 11

// // 82 -> 10

// // 9012 -> 12


// Console.Write(" Введите число :  ");
// int A = Convert.ToInt32(Console.ReadLine());

// int sumNumder (int n)
// {
//     int rez = 0;
//     int i = 0;
//     int s = n;
//     while (s > 1)
//     {
//         i = s % 10;
//         s = s/10;
//         rez = rez + i;

//     }
//     return rez;
// }


// Console.Write($"Cумма чисел :  {sumNumder(A)} ");
// Console.Write("-----------------------------");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return myArray;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Полученный массив ->:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите размер массива:");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение элемента массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива:");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(lenght, min, max);
ShowArray(newArray);