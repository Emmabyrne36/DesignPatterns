using System;
using DesignPatterns.Structural.Adapter.RefactoringGuruExample;

namespace DesignPatterns.Structural.Adapter
{
    public static class ExecuteAdapterPattern
    {
        public static void Execute()
        {
            ExecuteRefactoringGuru();
        }

        public static void ExecuteRefactoringGuru()
        {
            var adaptee = new Adaptee();
            ITarget target = new RefactoringGuruExample.Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());
        }
    }
}
