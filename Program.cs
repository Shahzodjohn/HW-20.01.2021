using System;

namespace HW_20._01._2021
{
    class Program
    {
        static void Main(string[] args)
        {/*Даны два неотрицательных числа a и b. Найти их среднее геометрическое, то
            есть квадратный корень из их произведения: √a·b.*/

            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            double result;
            result = Math.Pow(a * b, 0.5);
            Console.WriteLine(result);

            /*Даны три точки A, B, C на числовой оси. Найти длины отрезков AC и BC и их
             сумму.*/

            Console.Write("A = ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("B = ");
            Double B = double.Parse(Console.ReadLine());
            Console.Write("C = ");
            double C = double.Parse(Console.ReadLine());
            double AC;
            double BC;
            Double res;
            AC = Math.Abs(A - C);
            BC = Math.Abs(B - C);
            res = AC + BC;
            Console.WriteLine(AC);
            Console.WriteLine(BC);
            Console.WriteLine(res);
            /*Найти расстояние между двумя точками с заданными координатами (x1,y1) и
         (x2,y2) на плоскости. Расстояние вычисляется по формуле √((x2—x1)2+(y2—y1))*/

            Console.Write("x1 = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            Double x2 = double.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = double.Parse(Console.ReadLine());
            double Res;
            Res = Math.Pow(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2), 0.5);
            Console.WriteLine(Res);
            
            /*Дано двузначное число. Вывести число, полученное при перестановке цифр исходного числа.*/
            Console.Write("r = ");
            int r = Convert.ToInt32(Console.ReadLine());
            double Result;
            Result = (r % 10) * 10 + (r / 10);
            Console.WriteLine(Result);

            /*С начала суток прошло N секунд (N — целое).Найти количество полных минут,прошедших с начала суток.*/
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double RESULT;
            RESULT = n / 60;
            Console.WriteLine(RESULT);
            
            /*Дни недели пронумерованы следующим образом: 0 — воскресенье, 1 —
              понедельник, 2 — вторник, ..., 6 — суббота. Дано целое число K, лежащее в
              диапазоне 1–365. Определить номер дня недели для K-го дня года, если
              известно, что в этом году 1 января было понедельником.*/

            Console.Write("k = ");
            int k = Convert.ToInt32(Console.ReadLine());
            int m;
            m = k % 7;
            Console.WriteLine(m);
        }
    }
}
