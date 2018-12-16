using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_3_Operators
{
    public partial class Practice
    {
        /// <summary>
        /// B3-P1/5. NumbersAddition. Напишите алгоритм, который складывает два числа.
        /// </summary>
        public static void B3_P1_9_NumbersAddition()
        {
            Console.WriteLine("enter first number");
            var firstnumber = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("enter second number");
            var secondnumber = Convert.ToInt16(Console.ReadLine());

            var sum = firstnumber + secondnumber;
            Console.WriteLine($"{firstnumber} + {secondnumber} = {sum}");


        }

        /// <summary>
        /// B3-P2/9. CheckResultAddition. Изменить предыдущий алгоритм. 
        /// Пускай он теперь не выводит ответ сам. 
        /// А запрашивает ответ и потом проверяет его на правильность.
        /// </summary>
        public static void B3_P2_9_CheckResultAddition()
        {
            Console.WriteLine("Enter first number");
            var firstNumber = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter second number");
            var secondNumber = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter operator + or -");
            var oper = Console.ReadLine();

            Console.WriteLine("Enter your result");
            var answerSum = Convert.ToInt16(Console.ReadLine());



            var sum = firstNumber + secondNumber;
           
            if (answerSum == sum)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }

        /// <summary>
        /// B3-P3/9. CheckResultAdditionWithTips. Изменить предыдущий алгоритм. 
        /// Пускай он теперь выводит не только информацию правильно или не правильно, 
        /// но и дополнительно, 	ожидается число больше или меньше указанного.
        /// </summary>
        public static void B3_P3_9_CheckResultAdditionWithTips()
        {
            Console.WriteLine("Enter first number");
            var firstNumber = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter second number");
            var secondNumber = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter your result");
            var answerSum = Convert.ToInt16(Console.ReadLine());

            var sum = firstNumber + secondNumber;

            if (answerSum == sum)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                if (answerSum > sum)
                {
                    Console.WriteLine("Incorrect, expect amount less than you enter");
                }
                else
                {
                    Console.WriteLine("Incorrect, expect amount more than you enter");
                }
            }
        }

        /// <summary>
        /// B3-P4/9. CheckResultWithOperator. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм теперь запрашивает оператор (+ или -).
        /// </summary>
        public static void B3_P4_9_CheckResultWithOperator()
        {
            Console.WriteLine("Enter first number");
            var firstNumber = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter second number");
            var secondNumber = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter your result");
            var answerSum = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter your operand: 'p' for PLUS or 'm' for minus ");
            var operand = Console.ReadLine();


            switch (operand)
            {
                case "m":
                    {
                        var result = firstNumber - secondNumber;
                        if (answerSum == result)
                        {
                            Console.WriteLine("Correct");
                        }
                        else
                        {
                            if (answerSum > result)
                            {
                                Console.WriteLine("Incorrect, expect amount more than you enter");
                            }
                            else
                            {
                                Console.WriteLine("Incorrect, expect amount less than you enter");
                            }

                        }
                        break;
                    }
                case "p":
                    var result2 = firstNumber + secondNumber;
                    if (answerSum == result2)
                    {
                        Console.WriteLine("Correct");
                    }
                    else
                    {
                        if (answerSum > result2)
                        {
                            Console.WriteLine("Incorrect, expect amount less than you enter");
                        }
                        else
                        {
                            Console.WriteLine("Incorrect, expect amount more than you enter");
                        }

                    }










                    break;
            }


        }

        /// <summary>
        /// B3-P5/9. CheckResultWithAttemps. Изменить предыдущий алгоритм. 
        /// Пускай у пользователя будет 3 попытки чтобы решить эту задачу правильно
        /// </summary>
        public static void B3_P5_9_CheckResultWithAttemps()
        {

        }

        /// <summary>
        /// B3-P6/9. FiveNumbersAddition. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм складывает пять чисел вместо двух.
        /// </summary>
        public static void B3_P6_9_FiveNumbersAddition()
        {

        }

        /// <summary>
        /// B3-P7/9. NumbersResultWithInfoIfCorrect. Изменить предыдущий алгоритм. 
        /// В конце алгоритма выводить информацию была ли задача решена правильно.
        /// </summary>
        public static void B3_P7_9_NumbersResultWithInfoIfCorrect()
        {

        }

        /// <summary>
        /// B3-P8/9. CircleArea. Написать алгоритм, рассчитывающий площадь круга по заданному радиусу. 
        /// </summary>
        public static void B3_P8_9_CircleArea()
        {
            Console.WriteLine("Enter radius:");
            var radius = Convert.ToInt16(Console.ReadLine());

            var circleSquare = Math.PI * Math.Pow(radius,2);

            Console.WriteLine($"Circle square = {circleSquare}");
        }

        /// <summary>
        /// B3-P9/9. CreaditCalculator.Написать программу - калькулятор кредита на 1 год.
        /// </summary>
        public static void B3_P9_9_CreaditCalculator()
        {

        }
    }
}
