// НАПИСАЛ 3 ВЕРСИЮ, ДОБАВИЛ МЕНЮ И УЛУЧШИЛ ИНТЕРФЕЙС
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace GitWork
{
    internal class Program
    {
        // изучил классы и решил добавить в проект
        static void Main(string[] args)
        {
            Enter enter = new Enter();
            enter.Start();
            enter.CAlculator();
        }
    }

    class Enter
    {
        public void Start()
        {
            Console.WriteLine("Выберите:");
            Console.WriteLine("1. Калькулятор");
            Console.WriteLine("2. История вычислений");
            Console.WriteLine();
            if (Console.ReadLine() == "1") { CAlculator(); }
            else if (Console.ReadLine() == "2") { History(); }
        }

        public void CAlculator()
        {
            Console.Clear();
            Console.WriteLine("Введите операцию типа [x - y]");
            Calculator solution = new Calculator();
            solution.StrToNums();
        }

        public void History()
        {
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
        string allPath;
        string[] paths;
        public void StrToNums()
        {
            allPath = Console.ReadLine();
            Operations oper = new Operations();
            Enter enter = new Enter();

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
            else 
            { 
                Console.WriteLine("Операция не найдена");
            }
            Console.WriteLine("Нажмите любую клавишу чтобы перейти в меню...");
            Console.ReadKey();
            Console.Clear();
            enter.Start();
        }
    }
}
