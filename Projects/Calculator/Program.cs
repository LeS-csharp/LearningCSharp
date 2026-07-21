// НАПИСАЛ 2 ВЕРСИЮ С ПОДСЧЕТОМ И РАЗДЕЛИЛ ЕГО НА ДВА КЛАССА(БЕЗ СОХРАНЕНИЯ И ИСТОРИИ)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitWork
{
    internal class Program
    {
        // изучил классы и решил добавить в проект
        static void Main(string[] args)
        {
            Console.WriteLine("Введите операцию типа [x - y]");
            Calculator solution = new Calculator();
            char oper = solution.StrToNums();
        }
    }
    class Operations
    {
        public void Plus(double Fn, double Sn)
        {
            Console.WriteLine($"{Fn} + {Sn} = {Fn+Sn}");
        }

        public void Minus(double Fn, double Sn)
        {
            Console.WriteLine($"{Fn} - {Sn} = {Fn - Sn}");
        }

        public void Multiply(double Fn, double Sn)
        {
            Console.WriteLine($"{Fn} * {Sn} = {Fn * Sn}");
        }

        public void Divide(double Fn, double Sn)
        {
            Console.WriteLine(Sn == 0 ? "Не получится)" : $"{ Fn} / {Sn} = {Fn / Sn}");
        }
    }

    class Calculator
    {
        double Fn;
        double Sn;
        char operate;
        string allPath;
        string[] paths;
        public char StrToNums()
        {
            allPath = Console.ReadLine();
            Operations oper = new Operations();

            if (allPath.Contains("+"))
            {
                paths = allPath.Split('+');
                Fn = Convert.ToDouble(paths[0]);
                Sn = Convert.ToDouble(paths[1]);
                oper.Plus(Fn, Sn);
            }

            else if (allPath.Contains("-"))
            {
                paths = allPath.Split('-');
                Fn = Convert.ToDouble(paths[0]);
                Sn = Convert.ToDouble(paths[1]);
                oper.Minus(Fn, Sn);
            }

            else if (allPath.Contains("*"))
            {
                paths = allPath.Split('*');
                Fn = Convert.ToDouble(paths[0]);
                Sn = Convert.ToDouble(paths[1]);
                oper.Multiply(Fn, Sn);
            }

            else if (allPath.Contains("/"))
            {
                paths = allPath.Split('/');
                Fn = Convert.ToDouble(paths[0]);
                Sn = Convert.ToDouble(paths[1]);
                oper.Divide(Fn, Sn);
            }
            else { Console.WriteLine("Операция не найдена"); }
            return operate;
        }
    }
}

