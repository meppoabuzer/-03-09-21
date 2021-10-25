using System;

namespace ConsoleApp3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double a;
            double b;
            double total;
            char oper;

            Console.WriteLine("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите оператор:");
            oper = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());

            calc(a, b, oper);



        }

        public static double calc(double a, double b, char oper)
        {
            if (oper == '/')
            {
                return a / b;
                                Console.WriteLine("а");

            }

            else if (oper == '+')
            {
                
                double total = a + b;
                Console.WriteLine("Cумма " + a + " и " + b + " равна " + total);
                return a + b;
            }

            else if (oper == '-')
            {
                
                double total = a - b;
                Console.WriteLine("Разность " + a + " и " + b + " равна " + total);
                return a - b;
            }

            else if (oper == '*')
            {
                
                double total = a * b;
                Console.WriteLine("Умножение " + a + " на " + b + " равно " + total);
                return a * b;
            }

            else if (oper == '/')
            {
                
                double total = a / b;
                Console.WriteLine("Деление " + a + " на " + b + " равно " + total);
                return a / b;

            }
            else
            {
                Console.WriteLine("Неизвестный оператор.");
                return 1;
            }
        }
    }
}

ПКМ создние модульного теста
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MainTest()
        {
            double a = 5;
            double b = 5;
            char oper = '+';
            double res = 10;
            double act = Program.calc(a, b, oper);
            Assert.AreEqual(res, act);

        }
    }
}
