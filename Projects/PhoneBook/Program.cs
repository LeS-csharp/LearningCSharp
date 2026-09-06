using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GitWork
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Console.Clear();
            Console.WriteLine("**ТЕЛЕФОННАЯ КНИГА**");
            Console.WriteLine("--------------------");
            Console.WriteLine("1-добавить контакт");
            Console.WriteLine("2-удалить контакт");
            Console.WriteLine("3-изменить контакт");
            Console.WriteLine("4-найти по названию");
            Console.WriteLine("5-показать список контактов");
            Console.WriteLine("--------------------");
            string input = $"{Console.ReadLine()}";

            Manager manager = new Manager();

            switch (input)
            {
                case "1": { manager.Add(); } break;
                case "2": { manager.Remove(); } break;
                case "3": { manager.Rename(); } break;
                case "4": { manager.Found(); } break;
                case "5": { manager.Show(); } break;
                default: { Start(); } break;
            }
        }
    }

    class Manager
    {
        private Dictionary<string, string> phonename = new Dictionary<string, string>();
        
        public void Add() 
        {
            Console.Clear();//1
            Console.WriteLine("Введите имя и телефон без пробелов через \"/\" ");
            string input = $"{Console.ReadLine()}";
            string[] NaN;
            int trash;
            if(input.Contains("/"))
            {
                NaN = input.Split('/');
                if (int.TryParse(NaN[1], out trash))
                {
                    phonename.Add(NaN[1], NaN[0]);
                }
                else {Return(1);}
            }
            else {Return(1);}
        }
        public void Remove() //2
        {
            Console.Clear();
        }
        public void Rename() //3
        {
            Console.Clear();
        }
        public void Found() //4
        {
            Console.Clear();
        }
        public void Show() //5
        {
            Console.Clear();
            foreach (var i in phonename)
            {
                Console.WriteLine($"{i.Key} - {i.Value}");
            }
        }
        private void Return(int method)
        {
            Console.Clear();
            Console.WriteLine("Неверный ввод");
            switch(method)
            {
                case 1:{Add();}
                break;
                
                case 2:{Remove();}
                break;
                
                case 3:{Rename();}
                break;
                
                case 4:{Found();}
                break;
                
                case 5:{Show();}
                break;
            }
        }
    }
}
