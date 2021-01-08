using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioural.ChainOfResponsibility.RefactoringGuruExample
{
    public class DogHandler : AbstractHandler
    {
        public override object Handle(object request) => request.ToString() == "MeatBall"
            ? $"Dog: I'll eat the {request.ToString()}.\n"
            : base.Handle(request);
    }
}
