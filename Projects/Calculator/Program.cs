// НАПИСАЛ 1 ВЕРСИЮ С ПОДСЧЕТОМ(БЕЗ СОХРАНЕНИЯ И ИСТОРИИ)

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
            Operations solution = new Operations();
            char oper = solution.StrToNums();
            if (oper == '+') { solution.Plus(); }
            if (oper == '-') { solution.Minus(); }
            if (oper == '*') { solution.Multiply(); }
            if (oper == '/') { solution.Divide(); }
        }
    }
    class Operations
    {
        double Fn;
        double Sn;
        char operate;
        string allPath;
        string[] paths;
        public char StrToNums()
        {
            allPath = Console.ReadLine();

            if (allPath.Contains("+"))
            {
                operate = '+';
                paths = allPath.Split('+');
                Fn = Convert.ToDouble(paths[0]);
                Sn = Convert.ToDouble(paths[1]);
            }

            else if (allPath.Contains("-"))
            {
                operate = '-';
                paths = allPath.Split('-');
                Fn = Convert.ToDouble(paths[0]);
                Sn = Convert.ToDouble(paths[1]);
            }

            else if (allPath.Contains("*"))
            {
                operate = '*';
                paths = allPath.Split('*');
                Fn = Convert.ToDouble(paths[0]);
                Sn = Convert.ToDouble(paths[1]);
            }

            else if (allPath.Contains("/"))
            {
                operate = '/';
                paths = allPath.Split('/');
                Fn = Convert.ToDouble(paths[0]);
                Sn = Convert.ToDouble(paths[1]);
            }
            else { Console.WriteLine("Операция не найдена"); }
            return operate;
        }

        public void Plus()
        {
            Console.WriteLine($"{Fn} + {Sn} = {Fn+Sn}");
        }

        public void Minus()
        {
            Console.WriteLine($"{Fn} - {Sn} = {Fn - Sn}");
        }

        public void Multiply()
        {
            Console.WriteLine($"{Fn} * {Sn} = {Fn * Sn}");
        }

        public void Divide()
        {
            Console.WriteLine(Sn == 0 ? "Не получится)" : $"{ Fn} / {Sn} = {Fn / Sn}");
        }
    }
}
