using System;

namespace MethodFactory
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var creators = new Creator[]
            {
                new ConcreteCreatorA(), new ConcreteCreatorB()
            };
            foreach (var creator in creators)
            {
                Console.WriteLine(creator.FactoryMethod());
            }
        }
    }
}