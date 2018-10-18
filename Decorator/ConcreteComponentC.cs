using System;

namespace Decorator
{
    public class ConcreteComponentC : Decorator
    {
        public override void Operator()
        {
            base.Operator();
            AddedBehavior();
            Console.WriteLine("ConcreteComponentC.Operation()");
        }

        private static void AddedBehavior()
        {
            Console.WriteLine("ConcreteDecoratorC.AddedBehavior()");
        }
    }
}