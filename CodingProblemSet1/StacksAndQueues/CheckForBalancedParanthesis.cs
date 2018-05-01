using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblemSet1.StacksAndQueues
{
    class CheckForBalancedParanthesis
    {
        public static void Main()
        {
            CheckForBalancedParanthesisProcessor processor = new CheckForBalancedParanthesisProcessor();
            processor.Process();

            Console.ReadKey();
        }
    }

    class CheckForBalancedParanthesisProcessor
    {
        public void Process()
        {
            //string expressionToBeEvaluated = "[()]{}{[()()](}";
            string expressionToBeEvaluated = "[()]{}{[()()]()}";

            Console.WriteLine($"Is {expressionToBeEvaluated} a valid expression : {ValidateBalancedParanthesis(expressionToBeEvaluated)}");
        }

        private bool ValidateBalancedParanthesis(string expression)
        {
            char[] token = expression.ToCharArray();
            Stack<char> paranthesisStack = new Stack<char>();

            foreach (var item in token)
            {
                if (item == '(' || item == '{' || item == '[')
                {
                    paranthesisStack.Push(item);
                }
                
                if (item == ')' || item == '}' || item == ']')
                {

                    if (paranthesisStack.Count <= 0)
                    {
                        return false;
                    }

                    if (!IsMatchingPair(paranthesisStack.Pop(), item))
                    {
                        return false;
                    }
                }
            }

            if (paranthesisStack.Count > 0)
            {
                return false;
            }

            return true;
        }

        private bool IsMatchingPair(char openingCharacter, char closingCharacter)
        {
            switch (openingCharacter)
            {
                case '(':
                    return (closingCharacter == ')');
                case '{':
                    return (closingCharacter == '}');
                case '[':
                    return (closingCharacter == ']');
                default:
                    return false;
            }
        }
    }
}
