using System.Text;

namespace DesignPatterns.Structural.Facade
{
    // The Facade class provides a simple interface to the complex logic of one
    // or several subsystems. The Facade delegates the client requests to the
    // appropriate objects within the subsystem. The Facade is also responsible
    // for managing their lifecycle. All of this shields the client from the
    // undesired complexity of the subsystem.
    public class Facade
    {
        private readonly Subsystem1 _subsystem1;
        private readonly Subsystem2 _subsystem2;

        public Facade(Subsystem1 sub1, Subsystem2 sub2)
        {
            _subsystem1 = sub1;
            _subsystem2 = sub2;
        }

        // The Facade's methods are convenient shortcuts to the sophisticated
        // functionality of the subsystems. However, clients get only to a
        // fraction of a subsystem's capabilities.
        public string Operation()
        {
            var result = new StringBuilder("Facade initializes subsystems:\n");
            result.Append(_subsystem1.Operation1());
            result.Append(_subsystem2.Operation1());
            result.Append("Facade orders subsystems to perform the action:\n");
            result.Append(_subsystem1.OperationN());
            result.Append(_subsystem2.OperationZ());
            return result.ToString();
        }
    }
}
