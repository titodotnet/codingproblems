using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.StacksAndQueues
{
    class EvaluatePrefixExpression
    {
        public static void Main()
        {
            EvaluatePrefixExpressionProcessor processor = new EvaluatePrefixExpressionProcessor();
            processor.Process();
            Console.ReadKey();
        }
    }

    class EvaluatePrefixExpressionProcessor
    {
        public void Process()
        {
            string expression = "- + * 1 2 * 3 4 5";
            char[] delimiter = { ' ' };

            Evaluate(expression, delimiter);
        }

        private void Evaluate(string expression, char[] delimiter)
        {
            string[] tokens = expression.Split(delimiter);
            Stack<int> operandStack = new Stack<int>();

            for (int i = tokens.Length - 1; i >= 0; i--)
            {
                string item = tokens[i];
                int operand;

                if (int.TryParse(item, out operand))
                {
                    operandStack.Push(operand);
                }
                else
                {
                    int operand1 = operandStack.Pop();
                    int operand2 = operandStack.Pop();

                    switch (item)
                    {
                        case "+":
                            operandStack.Push(operand1 + operand2);
                            break;
                        case "-":
                            operandStack.Push(operand1 - operand2);
                            break;
                        case "*":
                            operandStack.Push(operand1 * operand2);
                            break;
                        case "/":
                            operandStack.Push(operand1 / operand2);
                            break;
                        default:
                            Console.WriteLine("Invalid expression");
                            break;
                    }
                }
            }

            Console.WriteLine($"Prefix Expression {expression} evaluated to: {operandStack.Pop()}");
        }
    }
}
