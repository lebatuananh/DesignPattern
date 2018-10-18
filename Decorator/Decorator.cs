namespace Decorator
{
    public abstract class Decorator : Component
    {
        public Component Component { get; private set; }

        public override void Operator()
        {
            Component?.Operator();
        }

        public void SetComponent(Component component)
        {
            Component = component;
        }
    }
}