using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxTree
{
    public interface INode
    {
        double GetValue();
    }
    public class NodeValue:INode
    {
        public int Value { get; set; }
        public double GetValue() => Value;
        public NodeValue(int value) => Value = value;
    }
    public enum Operation
    {
        Plus,
        Minus,
        Multiply,
        Divide
    }
    public class NodeOperation : INode
    {
        public Operation operation { get; set; }
        public INode Left { get; set; }
        public INode Right{get;set;}
        public double GetValue()
        {
            switch (operation)
            {
                case Operation.Plus:
                    return Left.GetValue() + Right.GetValue();
                case Operation.Minus:
                    return Left.GetValue() - Right.GetValue();
                case Operation.Multiply:
                    return Left.GetValue() * Right.GetValue();
                case Operation.Divide:
                    return Left.GetValue() / Right.GetValue();
                default:
                    throw new Exception();
            }
        }

        public NodeOperation(Operation operation, INode left, INode right)
        {
            this.operation = operation;
            Left = left;
            Right = right;
        }
    }
}
