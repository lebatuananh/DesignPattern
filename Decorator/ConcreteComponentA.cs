using System;

namespace Decorator
{
    public class ConcreteComponentA : Component
    {
        public override void Operator()
        {
            Console.WriteLine("ConcreteComponentA.Operation()");
        }
    }
}