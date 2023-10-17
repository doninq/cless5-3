/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/
//using System.CodeDom.Compiler;

double[] GenerateArroy(int n)
{
    double k = 0.1;
    double[] Arr = new double[n];
    for(int i = 0; i < n; i++)
    {
       Arr[i] = new Random().Next(-999, 999);
       Arr[i] = Arr[i]*k;
    }
    return Arr;
}

void PrintArray(double[] Arr)
    {
    Console.Write("[ ");  
    
    for (int i = 0; i < Arr.Length; i++)
    {
    Console.Write(Arr[i] + " ");        
    }
    Console.Write("]");  
    }


void MaxMin(double[] Arr)
{
    double min = Arr[0];
    double max = Arr[0];
    double Delta = 0;
    for(int i = 0; i < Arr.Length; i++)
    {
       if (Arr[i] > max) max = Arr[i+1];
       if (Arr[i] < min) min = Arr[i+1];
    }
    Delta = max-min;
    Console.Write(max + " " + min + " "+ Delta); 
}

Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine()!);
double[] Arr = GenerateArroy(n);
PrintArray(Arr);
MaxMin(Arr);
