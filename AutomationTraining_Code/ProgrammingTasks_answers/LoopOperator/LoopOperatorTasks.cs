namespace ProgrammingTasks_answers.LoopOperator
{
    public class LoopOperatorTasks(ILoopOperatorTask loopOperatorTask)
    {
        private readonly ILoopOperatorTask _loopOperatorTask = loopOperatorTask;

        public void ExecuteTask()
        {
            _loopOperatorTask.Execute();
        }
    }
}
