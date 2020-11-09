using System;

namespace DesignPatterns.Structural.Mediator
{
    // This is the abstract colleague
    public abstract class TeamMember
    {
        public string Name { get; }
        private Chatroom _chatroom { get; set; }

        public TeamMember(string name)
        {
            Name = name;
        }

        internal void SetChatroom(Chatroom chatroom)
        {
            _chatroom = chatroom;
        }

        public void Send(string message)
        {
            _chatroom.Send(Name, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"From {from}: '{message}'");
        }

        public void SendTo<T>(string message) where T : TeamMember
        {
            _chatroom.SendTo<T>(Name, message);
        }
    }
}
