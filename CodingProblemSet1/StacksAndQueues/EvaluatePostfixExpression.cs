using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.StacksAndQueues
{
    class EvaluatePostfixExpression
    {
        public static void Main()
        {
            EvaluatePostfixExpressionProcessor processor = new EvaluatePostfixExpressionProcessor();
            processor.Process();

            Console.ReadKey();
        }
    }

    class EvaluatePostfixExpressionProcessor
    {
        public void Process()
        {
            string expression = "1 2 * 3 4 * + 5 -";
            char[] delimiter = { ' ' };

            Evaluate(expression, delimiter);
        }

        private void Evaluate(string expression, char[] delimiter)
        {
            string[] tokens = expression.Split(delimiter);
            Stack<int> operandStack = new Stack<int>();

            foreach (var item in tokens)
            {
                int operand;
                if (int.TryParse(item, out operand))
                {
                    operandStack.Push(operand);
                }
                else
                {
                    int operand2 = operandStack.Pop();
                    int operand1 = operandStack.Pop();

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

            Console.WriteLine($"Postfix Expression {expression} evaluated to: {operandStack.Pop()}");
        }
    }
}
