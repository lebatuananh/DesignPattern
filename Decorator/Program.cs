namespace Decorator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var component = new ConcreteComponentA();
            var componentB = new ConcreteComponentB();
            var componentC = new ConcreteComponentC();

            componentB.SetComponent(component);
            componentC.SetComponent(component);
            componentC.Operator();
        }
    }
}