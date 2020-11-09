namespace DesignPatterns.NullObjectPattern
{
    public static class ExecuteNullObjectPattern
    {
        public static void Execute()
        {
            var learnerService = new LearnerService();
            ILearner learner = learnerService.GetCurrentLearner();

            var view = new LearnerView(learner);
            view.RenderView();
        }
    }
}
