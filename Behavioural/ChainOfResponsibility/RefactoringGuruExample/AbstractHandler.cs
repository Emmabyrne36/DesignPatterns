namespace DesignPatterns.Behavioural.ChainOfResponsibility.RefactoringGuruExample
{
    // The default chaining behaviour can be implemented inside a base handler class
    public class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            
            // Returning a handler from here will let us link handlers in a convenient way
            // E.G. monkey.SetNext(squirrel).SetNext(dog);
            return handler;
        }

        public virtual object Handle(object request) => _nextHandler?.Handle(request);

        // This method is the same as:
        // if (this._nextHandler != null)
        // {
        //     return this._nextHandler.Handle(request);
        // }
        // else
        // {
        //     return null;
        // }
    }
}
