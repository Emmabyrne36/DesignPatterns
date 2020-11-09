using System;

namespace DesignPatterns.Structural.Mediator
{
    public static class ExecuteMediatorPattern
    {
        public static void Execute()
        {
            var teamChat = new TeamChatroom();

            var aloy = new Developer("Aloy");
            var evie = new Developer("Evie");
            var kassandra = new Developer("Kassandra");
            var aya = new Tester("Aya");
            var ezio = new Tester("Ezio");

            teamChat.RegisterMembers(aloy, evie, kassandra, aya, ezio);

            aloy.Send("Hi everyone");
            aya.Send("Thanks");

            Console.WriteLine();

            aloy.SendTo<Developer>("Hi Devs");
        }
    }
}
