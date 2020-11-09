namespace DesignPatterns.Behavioural.Command
{
    public interface ICommand
    {
        void Execute();
        bool CanExecute();
        void Undo();
    }
}
