// 5 ВЕРСИЯ - 5TH VERSION

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
        }
    }

    class Enter
    {
        static Operations operations = new Operations();
        public void Start()
        {
            Console.Clear();
            Console.WriteLine("Выберите:");
            Console.WriteLine("1. Калькулятор");
            Console.WriteLine("2. История вычислений");
            Console.WriteLine();

            string text = Console.ReadLine();
            if (text == "1") { CAlculator(); }
            else if (text == "2") { Historyth(); }
            else {Start(); }
        }

        public void CAlculator()
        {
            Console.Clear();
            Console.WriteLine("Введите операцию типа [x - y] или \"BACK\" чтобы перейти в меню");
            Calculator solution = new Calculator();
            solution.StrToNums();
        }

        public void Historyth()
        {
            Console.Clear();
            History.ShowEX();
        }
    }

    class History
    {
        private static List<double> exmplars = new List<double>(); // ← static

        public static void AddReslt(double ex)  // ← static
        {
            exmplars.Add(ex);
        }

        public static void ShowEX()  // ← static
        {
            Console.Clear();
            if (exmplars.Count > 0)
            {
                Console.WriteLine("=== ИСТОРИЯ ВЫЧИСЛЕНИЙ ===\n");
                for (int i = 0; i < exmplars.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {exmplars[i]}");
                }
            }
            else
            {
                Console.WriteLine("История пуста. Вычислите что-нибудь");
            }

            Console.WriteLine("\nНажмите любую клавишу чтобы вернуться в меню...");
            Console.ReadKey();
            Console.Clear();
            Enter enter = new Enter();
            enter.Start();
        }
    }

    class Operations
    {
        Enter enter = new Enter();

        public void Plus(double Fn, double Sn)
        {
            Console.WriteLine($"{Fn} + {Sn} = {Fn + Sn}");
            Return(Fn + Sn);
        }

        public void Minus(double Fn, double Sn)
        {
            Console.WriteLine($"{Fn} - {Sn} = {Fn - Sn}");
            Return(Fn - Sn);
        }

        public void Multiply(double Fn, double Sn)
        {
            Console.WriteLine($"{Fn} * {Sn} = {Fn * Sn}");
            Return(Fn * Sn);
        }

        public void Divide(double Fn, double Sn)
        {
            Console.WriteLine(Sn == 0 ? "Не получится)" : $"{ Fn} / {Sn} = {Fn / Sn}");
            Return(Fn / Sn);
        }

        private void Return(double result)
        {
            Console.WriteLine("Нажмите любую клавишу чтобы сохранить результат...");
            Console.ReadKey();

            History.AddReslt(result);

            Console.Clear();
            enter.CAlculator();
        }
    }

    class Calculator
    {
        double Fn;
        double Sn;
        string allPath;
        string[] paths;
        Operations oper = new Operations();
        Enter enter = new Enter();

        private double[] ToOper(string[] paths)
        {
            double[] result;

            if (paths.Length > 1 && double.TryParse(paths[0], out Fn) && double.TryParse(paths[1], out Sn))
            {
                result = new double[] {Fn, Sn};
                return result;
            }

            else
            {
                return null;
            }
        }

        public void StrToNums()
        {
            allPath = Console.ReadLine();

            if (allPath.Contains("+"))
            {
                paths = allPath.Split('+');
                double[] nums = ToOper(paths);
                if (nums == null) { Console.WriteLine("Операция не найдена"); Return(); }
                else { oper.Plus(nums[0], nums[1]); }
            }

            else if (allPath.Contains("-"))
            {
                paths = allPath.Split('-');
                double[] nums = ToOper(paths);
                if (nums == null) { Console.WriteLine("Операция не найдена"); Return(); }
                else { oper.Minus(nums[0], nums[1]); }
            }

            else if (allPath.Contains("*"))
            {
                paths = allPath.Split('*');
                double[] nums = ToOper(paths);
                if (nums == null) { Console.WriteLine("Операция не найдена"); Return(); }
                else { oper.Multiply(nums[0], nums[1]); }
            }

            else if (allPath.Contains("/"))
            {
                paths = allPath.Split('/');
                double[] nums = ToOper(paths);
                if (nums == null) { Console.WriteLine("Операция не найдена"); Return(); }
                else { oper.Divide(nums[0], nums[1]); }
            }

            else if (allPath == "BACK")
            {
                enter.Start();
            }

            else 
            { 
                Console.WriteLine("Операция не найдена");
                Return();
            }
        }

        private void Return()
        {
            Console.WriteLine("Нажмите любую клавишу чтобы перезагрузить калькулятор...");
            Console.ReadKey();
            Console.Clear();
            enter.CAlculator();
        }
    }
}
