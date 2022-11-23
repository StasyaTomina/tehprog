using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cals
{
    class Program
    {
       
        static public double Calculate(string input)
        {
            string output = GetExpression(input);
            double result = Counting(output);
            return result;
        }
        static private string GetExpression(string input)
        {
            string output = string.Empty;
            Stack<char> operStack = new Stack<char>();


            for (int i = 0; i < input.Length; i++)

            {
                if (Char.IsDigit(input[i]))
                {
                    output += Checknumber(input, i);

                    while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
                    {
                        i++;

                        if (i == input.Length) break;
                    }

                    output += " ";
                    i--;
                }
                if (IsOperator(input[i]))
                {
                    output += CheckOperator(input, i, output, operStack)
                }
            }
            while (operStack.Count > 0)
                output += operStack.Pop() + " ";
            return output;
        }
        static private double Counting(string input)
        {

            {
                double result = 0;
                Stack<double> temp = new Stack<double>();

                for (int i = 0; i < input.Length; i++)
                {

                    if (Char.IsDigit(input[i]))

                    {
                        string a = string.Empty;

                        a += Variable(a, input, i, temp);
                        i += valueI(input, i);
                        temp.Push(double.Parse(a));
                        i--;
                    }
                    else if (IsOperator(input[i]))
                    {
                        result = Сounting(input, i, result, temp);
                        temp.Push(result);
                    }
                }
                return temp.Peek();
            }
        }
        public static string Checknumber(string input, int i)
        {
            string output = string.Empty;
            while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
            {
                output += input[i];
                i++;
                if (i == input.Length) break;
            }
            return output;
        }

        public static string CheckOperator(string input, int i, string output, Stack<char> operStack)
        {

            if (input[i] == '(')

                operStack.Push(input[i]);

            else if (input[i] == ')')
            {

                char s = operStack.Pop();

                while (s != '(')
                {
                    output += s.ToString() + ' ';

                    s = operStack.Pop();
                }
            }
            else
            {
                if (operStack.Count > 0)
                    if (GetPriority(input[i]) <= GetPriority(operStack.Peek()))
                        output += operStack.Pop().ToString() + " ";

                operStack.Push(char.Parse(input[i].ToString()));

            }
            return output;
        }
        public static string Variable(string a, string input, int i, Stack<double> temp)
        {
            while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
            {
                a += input[i];
                i++;
                if (i == input.Length) break;
            }
            return a;
        }
        public static int valueI(string input, int i)
        {
            while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
            {
                i++;
                if (i == input.Length) break;
            }
            i--;
            return i;
        }
        public static double Сounting(string input, int i, double result, Stack<double> temp)
        {
            double a = temp.Pop();
            double b = temp.Pop();
            switch (input[i])
            {
                case '+': result = b + a; break;
                case '-': result = b - a; break;
                case '*': result = b * a; break;
                case '/': result = b / a; break;
            }
            return result;
        }
        static private bool IsDelimeter(char c)
        {
            return " =".IndexOf(c) != -1;
        }
        private static bool IsOperator(char c)
        {
            return "+-/*()".IndexOf(c) != -1;
        }
        static private byte GetPriority(char s)
        {
            switch (s)
            {
                case '(': return 0;
                case ')': return 1;
                case '+': return 2;
                case '-': return 3;
                case '*': return 4;
                case '/': return 4;
                default: return 5;
            }
        }
    }



    class Cals

    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите выражение: ");
                Console.WriteLine(Program.Calculate(Console.ReadLine())); //Считываем, и выводим результат
            }
        }
    }
}

