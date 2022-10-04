int programm, arrayLenght, arrayMaxValue, arrayMinValue, count, sum;
Boolean begin = true;

double resultDifference;

int[] arrayInt = { };

while (begin)
{
Console.WriteLine("------");
Console.WriteLine("Введите № задачи или ctrl+c  для выхода:");
Console.WriteLine("34. Создаст массив заполненный случайными положительными трёхзначными числами.");
Console.WriteLine("   Покажет количество чётных чисел в массиве.");
Console.WriteLine("36. Создаст одномерный массив, заполненный случайными числами. ");
Console.WriteLine("   Найдёт сумму элементов, стоящих на нечётных позициях.");
Console.WriteLine("38. Создаст массив вещественных чисел.");
Console.WriteLine("   Находит разницу между максимальным и минимальным элементов массива.");

programm = Convert.ToInt32(Console.ReadLine());

switch (programm)
{
case 34:
// *Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
            
arrayLenght = 6;
arrayMaxValue = 1000;
arrayMinValue = 100;
count = 0;

arrayInt = ArrayIntGenerator(arrayLenght, arrayMaxValue, arrayMinValue);

            

for (int i = 0; i < arrayLenght; i++)
{
    if (arrayInt[i] % 2 == 0) count++;
}
Console.WriteLine($"Количество чётных чисел = {count}");
WaitingToAnyKey();
break;

case 36:
//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

arrayLenght = 5;
arrayMaxValue = 100;
arrayMinValue = -100;
sum = 0;

arrayInt = ArrayIntGenerator(arrayLenght, arrayMaxValue, arrayMinValue);

for (int i = 1; i < arrayLenght; i += 2)
{
sum += arrayInt[i];
}
Console.WriteLine($"Сумма чисел на нечётных позициях = {sum}");
WaitingToAnyKey();
break;

case 38:
//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

arrayLenght = 6;
arrayMaxValue = 100;
arrayMinValue = 1;

double minimalInArray = 0;
double maximalInArray = 0;

double[] arrayDoubleType = new double[arrayLenght];

for (int i = 0; i < arrayLenght; i++)
{
arrayDoubleType[i] = new Random().NextDouble();
arrayDoubleType[i] = arrayDoubleType[i] * (arrayMaxValue - arrayMinValue) + arrayMinValue;
arrayDoubleType[i] = Math.Round(arrayDoubleType[i], 2);
Console.Write(arrayDoubleType[i] + "; ");

if (i == 0)
{
    maximalInArray = arrayDoubleType[i];
    minimalInArray = arrayDoubleType[i];
}
    if (arrayDoubleType[i] > maximalInArray) maximalInArray = arrayDoubleType[i];
    if (arrayDoubleType[i] < minimalInArray) minimalInArray = arrayDoubleType[i];
}
Console.WriteLine();

resultDifference = maximalInArray - minimalInArray;
Console.WriteLine($"Разница между Max и Min значениями:");
Console.WriteLine($"{maximalInArray} - {minimalInArray} = {resultDifference}");
WaitingToAnyKey();
break;

        default:
            begin = false;
            break;
}
}

void WaitingToAnyKey() 
{
Console.Write("Нажмите любую кнопку: ");
Console.ReadKey();
Console.WriteLine();
}

int[] ArrayIntGenerator(int lenght, int maxValue, int minValue) 
{
int[] arrayInt = new int[lenght];

    for (int i = 0; i < lenght; i++)
    {
        arrayInt[i] = new Random().Next(minValue, maxValue);
        Console.Write(arrayInt[i] + "; ");
    }
    Console.WriteLine();
    return arrayInt;
}
