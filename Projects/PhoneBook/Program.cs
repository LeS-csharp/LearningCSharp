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
        static Manager manager = new Manager();

        static void Main(string[] args)
        {
            Start();
        }

        public static void Start()
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
            Console.Clear();
            Console.WriteLine("Введите имя и телефон без пробелов через \"/\" ");
            string input = $"{Console.ReadLine()}";
            string[] NaN;
            int trash;

            if (input.Contains("/"))
            {
                NaN = input.Split('/');

                if (int.TryParse(NaN[1], out trash))
                {
                    phonename.Add(NaN[0], NaN[1]);
                    Returne();
                }
                else
                {
                    WrongReturn(1);
                }
            }
            else
            {
                WrongReturn(1);
            }
        }

        public void Remove()
        {
            Console.Clear();

            if (phonename.Count == 0)
            {
                Console.WriteLine("Список ваших контактов пустой");
                Returne();
            }
            else
            {
                Console.WriteLine("Введите имя контакта для удаления");
                string input = Console.ReadLine();
                string trash = "";

                if (phonename.TryGetValue(input, out trash))
                {
                    phonename.Remove(input);
                    Console.WriteLine($"Вы успешно удалили {input} из списка контактов");
                    Returne();
                }
                else
                {
                    Console.WriteLine("Не нашли данного контакта в вашем списке.");
                    Returne();
                }
            }
        }

        public void Rename()
        {
            Console.Clear();

            if (phonename.Count == 0)
            {
                Console.WriteLine("Список ваших контактов пустой");
                Returne();
            }
            else
            {
                Console.WriteLine("Введите имя контакта для изменения");
                string input = Console.ReadLine();
                string trash = "";

                if (phonename.TryGetValue(input, out trash))
                {
                    Console.WriteLine("Введите новое имя контакта");
                    string newInput = Console.ReadLine();

                    phonename.Add(newInput, phonename[input]);
                    phonename.Remove(input);

                    Console.WriteLine($"Вы успешно изменили {input} на {newInput}");
                    Returne();
                }
                else
                {
                    Console.WriteLine("Не нашли данного контакта в вашем списке.");
                    Returne();
                }
            }
        }

        public void Found()
        {
            Console.Clear();

            if (phonename.Count == 0)
            {
                Console.WriteLine("Список ваших контактов пустой");
                Returne();
            }
            else
            {
                Console.WriteLine("Введите имя для поиска контакта");
                string input = Console.ReadLine();
                string trash = "";

                if (phonename.TryGetValue(input, out trash))
                {
                    Console.WriteLine($"{input} - {trash}");
                    Returne();
                }
                else
                {
                    WrongReturn(4);
                }
            }
        }

        public void Show()
        {
            Console.Clear();

            if (phonename.Count == 0)
            {
                Console.WriteLine("Список ваших контактов пустой");
                Returne();
            }
            else
            {
                foreach (var i in phonename)
                {
                    Console.WriteLine($"{i.Key} - {i.Value}");
                }

                Returne();
            }
        }

        private void WrongReturn(int method)
        {
            Console.Clear();
            Console.WriteLine("Неверный ввод");

            switch (method)
            {
                case 1:
                    {
                        Add();
                    }
                    break;

                case 2:
                    {
                        Remove();
                        Console.WriteLine("Обьект не найден, нажмите любую кнопку чтобы вернуться в меню");
                        Console.ReadKey();
                    }
                    break;

                case 3:
                    {
                        Rename();
                        Console.WriteLine("Обьект не найден, нажмите любую кнопку чтобы вернуться в меню");
                        Console.ReadKey();
                    }
                    break;

                case 4:
                    {
                        Found();
                        Console.WriteLine("Обьект не найден, нажмите любую кнопку чтобы вернуться в меню");
                        Console.ReadKey();
                    }
                    break;

                case 5:
                    {
                        Show();
                    }
                    break;
            }
        }

        void Returne()
        {
            Console.WriteLine("Нажмите любую кнопку чтобы вернуться в меню");
            Console.ReadKey();
            Program.Start();
        }
    }
}