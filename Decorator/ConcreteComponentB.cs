using System;

namespace Decorator
{
    public class ConcreteComponentB : Decorator
    {
        public override void Operator()
        {
            base.Operator();
            Console.WriteLine("ConcreteComponentB.Operation()");
        }
    }
}