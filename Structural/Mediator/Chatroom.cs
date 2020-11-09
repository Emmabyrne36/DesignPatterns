namespace DesignPatterns.Structural.Mediator
{
    // This is the mediator
    public abstract class Chatroom
    {
        public abstract void Register(TeamMember member);
        public abstract void Send(string from, string message);
        public abstract void SendTo<T>(string from, string message) where T : TeamMember;
    }
}
