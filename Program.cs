using DesignPatterns.Behavioural.Command;
using DesignPatterns.Behavioural.Strategy;
using DesignPatterns.Structural.Composite.BasicExample;
using DesignPatterns.Structural.Composite.RealWorldExample;
using DesignPatterns.Structural.Mediator;

namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            ExecuteStrategyPattern.Execute();
            ExecuteCommandPattern.Execute();
            ExecuteMediatorPattern.Execute();
            ExecuteBasicCompositeExample.Execute();
            ExecuteRealWorldCompositeExample.Execute();
            ExecuteRealWorldCompositeExample.BuilderExecute();
        }
    }
}
