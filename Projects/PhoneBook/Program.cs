using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
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
            string input = Console.ReadLine();

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
        public void Add() 
        {
            Console.Clear();
        }
        public void Remove() 
        {
            Console.Clear();
        }
        public void Rename() 
        {
            Console.Clear();
        }
        public void Found() 
        {
            Console.Clear();
        }
        public void Show() 
        {
            Console.Clear();
        }
    }
}
