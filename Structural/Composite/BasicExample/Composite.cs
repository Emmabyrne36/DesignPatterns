using System;
using System.Collections.Generic;

namespace DesignPatterns.Structural.Composite.BasicExample
{
    public class Composite : Component
    {
        private readonly List<Component> _children = new List<Component>();

        public Composite(string name) : base(name)
        {
        }

        public void Add(Component c)
        {
            _children.Add(c);
        }

        public override void PrimaryOperation(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);
            foreach (var component in _children)
            {
                component.PrimaryOperation(depth + 2);
            }
        }

        public void Remove(Component c)
        {
            _children.Remove(c);
        }
    }
}
