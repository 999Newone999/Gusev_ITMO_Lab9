using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gusev_ITMO_Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool inputNotOk;
            bool operationNotOk;
            bool divideByZero;
            int x=0, y=0;
            float result=0;
            Console.WriteLine("Калькулятор");
            do
            {
                Console.Write("Введите целое число. X= ");
                inputNotOk = false;
                try
                {
                    x = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Х введен в неверном формате");
                    inputNotOk = true;
                }
            }while(inputNotOk);

            do
            {
                divideByZero = false;
                do
                {
                    Console.Write("Введите целое число. Y= ");
                    inputNotOk = false;
                    try
                    {
                        y = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Y введен в неверном формате");
                        inputNotOk = true;
                    }
                } while (inputNotOk);

                do
                {
                    Console.Write("Введите операцию (\"+\"-Х+Y, \"-\" - X-Y , \"*\" - X*Y,  \"-\" - X/Y): ");
                    operationNotOk = false;
                        switch (Console.ReadLine())
                        {
                            case "+":
                                result = (float)(x + y);
                                break;

                            case "-":
                                result = (float)(x - y);
                                break;

                            case "*":
                                result = (float)(x * y);
                                break;

                            case "/":
                               try
                                {
                                   result = x / y; // внедряем лишнее целочисленное деление для того чтобы срабатывало прерывание при делении на ноль
                                   result = (float)x / (float)y;
                                }
                                catch 
                                {
                                    Console.WriteLine("Ошибка: деление на ноль.");
                                    divideByZero = true;
                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Неверный ввод операции.");
                                    operationNotOk = true;
                                    break;
                                } 
                         }
                } while (operationNotOk);
            } while (divideByZero);

            
            Console.WriteLine(Math.Round(result,4));
            Console.ReadKey();
            
        }
    }
}
