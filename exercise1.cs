using System;    //включаем работу с консолью

namespace LABA1C_
{
    internal class Program
    {
        static void Main(string[] args)   //Вход в программу
        {
            Console.WriteLine("Минимальные и максимальные значения предопределенных типов данных CTS:");

            // Целочисленные типы данных
            Console.WriteLine($"byte: min = {byte.MinValue}, max = {byte.MaxValue}");
            Console.WriteLine($"sbyte: min = {sbyte.MinValue}, max = {sbyte.MaxValue}");
            Console.WriteLine($"short: min = {short.MinValue}, max = {short.MaxValue}");
            Console.WriteLine($"ushort: min = {ushort.MinValue}, max = {ushort.MaxValue}");
            Console.WriteLine($"int: min = {int.MinValue}, max = {int.MaxValue}");
            Console.WriteLine($"uint: min = {uint.MinValue}, max = {uint.MaxValue}");
            Console.WriteLine($"long: min = {long.MinValue}, max = {long.MaxValue}");
            Console.WriteLine($"ulong: min = {ulong.MinValue}, max = {ulong.MaxValue}");

            // Типы данных с плавающей точкой
            Console.WriteLine($"float: min = {float.MinValue}, max = {float.MaxValue}");
            Console.WriteLine($"double: min = {double.MinValue}, max = {double.MaxValue}");
            Console.WriteLine($"decimal: min = {decimal.MinValue}, max = {decimal.MaxValue}");

            // Логический тип данных
            Console.WriteLine($"bool: true / false");

            // Символьный тип данных
            Console.WriteLine($"char: min = {char.MinValue}, max = {char.MaxValue}");

            // Структуры
            Console.WriteLine($"DateTime: min = {DateTime.MinValue}, max = {DateTime.MaxValue}");
            Console.WriteLine($"TimeSpan: min = {TimeSpan.MinValue}, max = {TimeSpan.MaxValue}");

            // Тип значений null
            Console.WriteLine($"Nullable<T>: null");

            Console.ReadKey(); //Ожидание ввода пользователем в консоль
        }
    }
}


