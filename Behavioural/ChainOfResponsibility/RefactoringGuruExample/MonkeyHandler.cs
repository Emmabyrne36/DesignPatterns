namespace DesignPatterns.Behavioural.ChainOfResponsibility.RefactoringGuruExample
{
    public class MonkeyHandler : AbstractHandler
    {
        public override object Handle(object request) =>
            request.ToString() == "Banana" ? $"Monkey: I'll eat the {request.ToString()}.\n" : base.Handle(request);
    }
}
