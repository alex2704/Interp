using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxTree
{
    public class Tree
    {
        INode Root { get; set; }
        public double GetValue() => Root.GetValue();
        private string str;
        private INode GetNode(int index, int Count)
        {
            int braces = 0;
            while(true)
            {
                while (str[index] == ' ')
                {
                    index++;
                    Count--;
                }
                while (str[index + Count - 1] == ' ')
                {
                    Count--;
                }
                bool t = false;
                if (str[index] == '(' && str[index + Count - 1] == ')')
                {
                    t = true;
                    braces = 0;
                    for (int i = index+1; i < index+Count-1; i++)
                    {
                        if (str[i] == '(')
                            braces++;
                        if (str[i] == ')')
                            braces--;
                        if (braces == -1)
                        {
                            t = false;
                            break;
                        }
                    }
                }
                if (t)
                {
                    index++;
                    Count -= 2;
                }
                else break;
            }
            braces = 0;
            for (int i = index+Count-1; i >= index; i--)
            {
                switch (str[i])
                {
                    case '(':
                        braces++;
                        break;
                    case ')':
                        braces--;
                        break;
                    case '+':
                    case '-':
                        if (braces == 0)
                            return new NodeOperation(str[i] == '+'?Operation.Plus:Operation.Minus, GetNode(index, i - index), GetNode(i + 1, Count + index - i - 1));
                        break;
                }
            }
            for (int i = index + Count - 1; i >= index; i--)
            {
                switch (str[i])
                {
                    case '(':
                        braces++;
                        break;
                    case ')':
                        braces--;
                        break;
                    case '*':
                    case '/':
                        if (braces == 0)
                            return new NodeOperation(str[i] == '*' ? Operation.Multiply : Operation.Divide, GetNode(index, i - index), GetNode(i + 1, Count + index - i - 1));
                        break;
                }
            }
            if (int.TryParse(str.Substring(index, Count), out int result))
                return new NodeValue(result);
            else throw new ArgumentException();
        }
        public Tree(string str)
        {
            int braces = 0;
            foreach (char item in str)
            {
                if (item == '(')
                    braces++;
                if (item == ')')
                    braces--;
                if (braces == -1)
                    throw new ArgumentException();
            }
            if (braces != 0)
                throw new ArgumentException();
            this.str = str;
            Root = GetNode(0, str.Length);
        }
    }
}
