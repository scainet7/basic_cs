/*
Переменная - это поименованная или адресуемая каким-то образом облать памяти,
    адрес которой мы используем для получения доступа к файлам или изменения значения в ходе исполнения программы

Обьявление переменной - это создание переменной в тексте программы;

Инициализация - присвоение начального значения переменной;

тип <имя переменной> = занчение

Основные типы переменных:
    
    Целочисленные типы

    byte    0 до 255
    sbyte   -128 до 128
    short   -32768 до 32767
    ushort  0 до 65535
    int     -2147483648 до 2147483647
    long    
    ulong      

    Типы с плавающей точкой

    float точность до 7ми знаков после запятой
    double  до 15-ти знаков после запятой

    Симпольный тип

    char c = ' ' 
    
    Строковый тип

    string str = " "

    Логический тип

    bool
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello мир!"); //Вывод в консоль
            
            byte    b = 0;
            sbyte   sb = -2;
            short   sh = 12;
            ushort  ush = 156;
            int     i = 23;
            long    lg = 234345;
            ulong   ulg = 78780879;

            float   fl = 6.4f;
            double  db = 6.4;
            
            bool    flag = true;
            
            char    c = '\0';
            
            string  str = "Hell0";


            Console.ReadKey();  //Задержка  сонсольного окна


        }
    }
}
