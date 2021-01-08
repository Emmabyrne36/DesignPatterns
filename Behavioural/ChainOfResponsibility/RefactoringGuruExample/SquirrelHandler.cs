namespace DesignPatterns.Behavioural.ChainOfResponsibility.RefactoringGuruExample
{
    public class SquirrelHandler : AbstractHandler
    {
        public override object Handle(object request) => request.ToString() == "Nut"
            ? $"Squirrel: I'll eat the {request.ToString()}.\n"
            : base.Handle(request);
    }
}
