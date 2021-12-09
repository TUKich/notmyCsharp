using System;
using System.Linq;

namespace Лаба_Юрка
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                BinaryNumber bNum1;
                BinaryNumber bNum2;
                BinaryNumber bNum3;
                BinaryNumber bNum4;

                //Обработка исключений
                try
                {
                    bNum1 = new BinaryNumber("10011");
                    bNum2 = new BinaryNumber("0011");
                    bNum3 = new BinaryNumber("10101");
                    bNum4 = new BinaryNumber("0011");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                    return;
                }

                //Сложение
                BinaryNumber bNumRes1 = bNum1 + bNum2;
                Console.WriteLine(bNumRes1);

                //Вычитание
                BinaryNumber bNumRes2 = bNum3 - bNum4;
                Console.WriteLine(bNumRes2);

                //Умножение
                BinaryNumber bNumRes3 = bNum1 * bNum2;
                Console.WriteLine(bNumRes3);

                //Деление
                BinaryNumber bNumRes4 = bNum3 / bNum4;
                Console.WriteLine(bNumRes4);

                //Сравнение
                Console.WriteLine(bNum2.Equals(bNum4));
                Console.ReadLine();
            }
        }

        public class BinaryNumber
        {
            //Внутренее значение числа
            private int innerNumber;

            //Конструктор с проверкой формата параметра
            public BinaryNumber(string bNumber)
            {
                bool res = bNumber.ToCharArray().Any(n => (n != '0' && n != '1'));
                if (res)
                    throw new FormatException("Неверный формат данных!");

                innerNumber = Convert.ToInt32(bNumber, 2);
            }

            //Перегрузка оператора +
            public static BinaryNumber operator +(BinaryNumber bn1, BinaryNumber bn2)
            {
                int b1 = Convert.ToInt32(bn1.ToString(), 2);
                int b2 = Convert.ToInt32(bn2.ToString(), 2);
                return new BinaryNumber(Convert.ToString(b1 + b2, 2));
            }

            //Перегрузка оператора -
            public static BinaryNumber operator -(BinaryNumber bn1, BinaryNumber bn2)
            {
                int b1 = Convert.ToInt32(bn1.ToString(), 2);
                int b2 = Convert.ToInt32(bn2.ToString(), 2);
                return new BinaryNumber(Convert.ToString(b1 - b2, 2));
            }

            //Перегрузка оператора *
            public static BinaryNumber operator *(BinaryNumber bn1, BinaryNumber bn2)
            {
                int b1 = Convert.ToInt32(bn1.ToString(), 2);
                int b2 = Convert.ToInt32(bn2.ToString(), 2);
                return new BinaryNumber(Convert.ToString(b1 * b2, 2));
            }

            //Перегрузка оператора /
            public static BinaryNumber operator /(BinaryNumber bn1, BinaryNumber bn2)
            {
                int b1 = Convert.ToInt32(bn1.ToString(), 2);
                int b2 = Convert.ToInt32(bn2.ToString(), 2);
                return new BinaryNumber(Convert.ToString(b1 / b2, 2));
            }

            //Перегрузка Equals
            public override bool Equals(object obj)
            {
                if (obj is BinaryNumber)
                {
                    if (this.ToString() == ((BinaryNumber) obj).ToString())
                        return true;
                }

                return false;
            }

            //Перегрузка GetHashCode
            public override int GetHashCode()
            {
                return this.ToString().GetHashCode();
            }

            //Перегрузка ToString()
            public override string ToString()
            {
                return Convert.ToString(innerNumber, 2);
            }
        }
    }
}