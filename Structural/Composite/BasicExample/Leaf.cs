using System;

namespace DesignPatterns.Structural.Composite.BasicExample
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void PrimaryOperation(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);
        }
    }
}
