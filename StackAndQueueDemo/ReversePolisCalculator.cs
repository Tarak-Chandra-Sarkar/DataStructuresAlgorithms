using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueueDemo
{
    public class ReversePolisCalculator
    {
        public static void RPNCalculator()
        {
            while (true)
            {
                Console.Write(">");
                string input = Console.ReadLine();
                if (input.Equals("q", StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                }

                Stack<int> stack = new Stack<int>();

                foreach (var token in input.Split(new char[] {' '}))
                {
                    int value;
                    if (int.TryParse(token, out value))
                    {
                        // ... push it to the stack. 
                        stack.Push(value);
                    }
                    else
                    {
                        int lhs = stack.Pop();
                        int rhs = stack.Pop();

                        switch (token)
                        {
                            case "+":
                                stack.Push(lhs + rhs);
                                break;
                            case "-":
                                stack.Push(lhs - rhs);
                                break;
                            case "*":
                                stack.Push(lhs * rhs);
                                break;
                            case "/":
                                stack.Push(lhs / rhs);
                                break;
                            case "%":
                                stack.Push(lhs % rhs);
                                break;
                            default:
                                throw new ArgumentException(string.Format("Unrecognized token: {0}", token));
                        }
                    }

                }
                Console.WriteLine(stack.Pop());

            }

        }
    }
}
