using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Stack
{
    public class PostfixCalculator
    {
        public static void Main(string[] args)
        {
            Stack<int> _stack = new Stack<int>();

            foreach (string token in args)
            {
                int value;
                if (int.TryParse(token, out value))
                {
                    _stack.Push(value);
                }
                else
                {
                    int rhs = _stack.Pop();
                    int lhs = _stack.Pop();
                    switch (token)
                    {
                        case "+":
                            _stack.Push(lhs + rhs);
                            break;
                        case "-":
                            _stack.Push(lhs - rhs);
                            break;
                        case "*":
                            _stack.Push(lhs * rhs);
                            break;
                        case "/":
                            _stack.Push(lhs / rhs);
                            break;
                        case "%":
                            _stack.Push(lhs % rhs);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException(string.Format("Unrecognized Toke:{0}", token));
                    }
                }
            }
        }

    }
}
