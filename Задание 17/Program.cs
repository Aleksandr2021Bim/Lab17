using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello инженер \nпроверьте свой баланс счета в банке");
            Console.WriteLine("Введите номер счёта");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите баланс счёта");
            double balance1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО");
            string name1 = Console.ReadLine();

            BankAccount<int> bankAccount1 = new BankAccount<int>(num1,balance1,name1);

            Console.WriteLine("Введите номер счёта");
            string num2 = Console.ReadLine();
            Console.WriteLine("Введите баланс счёта");
            double balance2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ФИО");
            string name2 =Console.ReadLine();

            BankAccount<string> bankAccount2 = new BankAccount<string>(num2,balance2,name2);

            bankAccount1.Print();
            bankAccount2.Print();

             Console.ReadKey();
        }
    }

    class BankAccount<T>
    {
        private T Num;
        private double Balance;
        private string Name;

        public BankAccount(T num, double balance, string name)
        {
            Num = num;
            Balance = balance;
            Name = name;
        }

        public void Print()
        {
            Console.WriteLine("Номер счета - {0}", Num);
            Console.WriteLine("Баланс счета - {0}", Balance);
            Console.WriteLine("ФИО - {0}", Name);
        }

    }
}
