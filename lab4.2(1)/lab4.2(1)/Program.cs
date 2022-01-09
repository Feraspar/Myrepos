using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._2_1_
{
    class Program
    {
        public static int A = 0;
        public static int B = 0;
        public static int res = 0;


        static void Main(string[] args)
        {
            int value = 1;
            while (value == 1)
            {

                Console.WriteLine(Environment.NewLine + "Выберите пункт меню: ");
                Console.WriteLine("1. Ввести A");
                Console.WriteLine("2. Ввести B");
                Console.WriteLine("3. Выполнить сложение");
                Console.WriteLine("4. Выполнить вычитание");
                Console.WriteLine("5. Выполнить умножение");
                Console.WriteLine("6. Выполнить деление");

                var key = Console.ReadKey();
                int i;

                if (char.IsDigit(key.KeyChar))
                {
                    i = Convert.ToInt32(key.KeyChar.ToString());
                    switch (i)
                    {
                        case (char)1:
                            Console.WriteLine(Environment.NewLine + "Введите А: ");
                            A = Convert.ToInt32(Console.ReadLine());
                            break;

                        case (char)2:
                            Console.WriteLine(Environment.NewLine + "Введите B: ");
                            B = Convert.ToInt32(Console.ReadLine());
                            break;

                        case (char)3:
                            add();
                            break;

                        case (char)4:
                            sub();
                            break;

                        case (char)5:
                            mult();
                            break;

                        case (char)6:
                            seg();
                            break;
                    }
                }
                else
                {
                    i = -1;
                    Console.WriteLine(Environment.NewLine + "Введите корректное число");
                }
            }
        }
    }
}
