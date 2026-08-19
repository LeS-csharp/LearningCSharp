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

        static void Main(string[] args)
        {
            Console.WriteLine("**ТЕЛЕФОННАЯ КНИГА**");
            Console.WriteLine("--------------------");
            Console.WriteLine("1-добавить контакт");
            Console.WriteLine("2-удалить контакт");
            Console.WriteLine("3-найти по названию");
            Console.WriteLine("--------------------");
            string input = Console.ReadLine();
        }
    }
}
