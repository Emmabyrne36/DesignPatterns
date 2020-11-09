using System;

namespace DesignPatterns.Structural.Mediator
{
    // This is the concrete colleague
    public class Tester : TeamMember
    {
        public Tester(string name) : base(name)
        {
        }

        public override void Receive(string @from, string message)
        {
            Console.Write($"{Name} ({nameof(Tester)}) has received: ");
            base.Receive(@from, message);
        }
    }
}
