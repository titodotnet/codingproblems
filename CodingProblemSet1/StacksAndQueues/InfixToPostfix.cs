using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.StacksAndQueues
{
    class InfixToPostfix
    {
        public static void Main()
        {
            InfixToPostfixProcessor processor = new InfixToPostfixProcessor();
            processor.Process();

            Console.ReadKey();
        }
    }

    class InfixToPostfixProcessor
    {
        public void Process()
        {
            //string expression = "A + B * C + D";
            string expression = "( ( A * B ) + ( C * D ) ) - E";
            char[] delimiter = { ' ' };

            ConvertInfixToPostfix(expression, delimiter);
        }

        private void ConvertInfixToPostfix(string expression, char[] delimiter)
        {
            string[] tokens = expression.Split(delimiter);
            Stack<string> operatorStack = new Stack<string>();
            string result = string.Empty;


            foreach (var item in tokens)
            {
                if (IsLetterOrDigit(item))
                {
                    result = $"{result} {item}";
                }
                else if (item == "(")
                {
                    operatorStack.Push(item);
                }
                else if (item == ")")
                {
                    while (operatorStack.Count > 0 && operatorStack.Peek() != "(")
                    {
                        result = $"{result} {operatorStack.Pop()}";
                    }

                    if (operatorStack.Count > 0 && operatorStack.Peek() == "(")
                    {
                        operatorStack.Pop();
                    }
                    else
                    {
                        Console.WriteLine($"Invalid expression: {expression}");
                    }
                }
                else
                {
                    while (operatorStack.Count > 0 && (Precedence(item) <= Precedence(operatorStack.Peek())))
                    {
                        result = $"{result} {operatorStack.Pop()}";
                    }

                    operatorStack.Push(item);
                }
            }

            while (operatorStack.Count > 0)
            {
                result = $"{result} {operatorStack.Pop()}";
            }

            Console.WriteLine($"Infix expression {expression} evaluated to postfix expression {result}");
        }

        private int Precedence(string operatorItem)
        {
            switch (operatorItem)
            {
                case "+":
                case "-":
                    return 1;
                case "*":
                case "/":
                    return 2;
                case "^":
                    return 3;
                default:
                    return -1;
            }
        }

        private bool IsLetterOrDigit(string stringToBeEvaluated)
        {
            foreach (var item in stringToBeEvaluated)
            {
                if (!char.IsLetterOrDigit(item))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
