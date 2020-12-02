using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Facade
{
    public class ExecuteFacadePattern
    {
        public static void Execute()
        {
            // The client code may have some of the subsystem's objects already
            // created. In this case, it might be worthwhile to initialize the
            // Facade with these objects instead of letting the Facade create
            // new instances.
            var sub1 = new Subsystem1();
            var sub2 = new Subsystem2();
            var facade = new Facade(sub1, sub2);

            Client.ClientCode(facade);
        }
    }
}
