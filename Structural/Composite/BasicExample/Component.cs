namespace DesignPatterns.Structural.Composite.BasicExample
{
    public abstract class Component
    {
        protected Component(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public abstract void PrimaryOperation(int depth);
    }
}
