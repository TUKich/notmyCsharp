using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;

namespace ConsoleApp2
{
    class Program
    {
        class Action
        {
            private int YEAR;
            private int MONTH;
            private int DAY;

            public int year
            {

                get { return YEAR; }
                set
                {
                    try
                    {
                        if (value < 0) throw new Exception();
                        else
                        {
                            this.YEAR = value;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Возникло исключение: "+e.Message);
                        
                    }

                }
            }
            public int month
            {
                get { return MONTH; }
                set
                {
                    try
                    {
                        if (value < 0) throw new Exception();
                        else
                        {
                            if (value > 12)
                                throw new Exception();
                            else
                            {
                                this.MONTH = value;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Возникло исключение: "+e.Message);
                        
                    }
                   
                }
            }

            public int day
            {
                get { return DAY; }
                set
                {
                    try
                    {
                        if (value < 0) throw new Exception();
                        else
                        {
                            if (value > 31) throw new Exception();
                            else
                            {
                                if ((MONTH == 2) && (value > 28))
                                    throw new Exception();
                                else
                                {
                                    if ((MONTH == 4) && (MONTH == 6) && (MONTH == 9) && (MONTH == 11))
                                        throw new Exception();
                                    else
                                    {
                                        this.DAY = value;
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Возникло исключение: "+e.Message);
                        
                    }
                    
                }
            }
            public int[] cool = new int[] {1, 3, 5, 7, 8, 10, 12};
            public int[] nocool = new int[] {4, 6, 9, 11};
            public int deadmonth = 2;

            public Action(int year, int month, int day)
            {
                this.year = year;
                this.month = month;
                this.day = day;
            }

            public void outputdate()
            {
                Console.Write(day + "." + month + "." + year + "\n");
            }
        }
        public static void Main(string[] args)
        {
            Action action = new Action(0, 0, 0);
            Console.WriteLine("Дата поставлена по умолчанию: ");
            action.outputdate();
            int a;
            Boolean b = true;
            while (b)
            {
                Console.WriteLine(
                    "1.Изменить год\n2.Изменить месяц\n3.Изменить День\n4.Посмотреть на дату\n0.Закончить");
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        try
                        {
                            action.year = Convert.ToInt32(Console.ReadLine());
                            
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                        break;
                        
                    case 2:
                        try
                        {
                            action.month = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);

                        }
                        
                        break;
                    case 3:
                        try
                        {
                            action.day = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            
                        }

                        break;
                    case 4:
                        action.outputdate();
                        break;
                    case 0:
                        b = false;
                        break;
                    default:

                        break;
                }
            }
        }
    }
}