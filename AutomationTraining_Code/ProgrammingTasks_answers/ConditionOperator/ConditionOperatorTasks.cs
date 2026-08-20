namespace ProgrammingTasks_answers
{
    public class ConditionOperatorTasks(IConditionOperatorTask conditionOperatorTask)
    {
        private readonly IConditionOperatorTask _conditionOperatorTask = conditionOperatorTask;

        public void ExecuteTask()
        {
            _conditionOperatorTask.Execute();
        }
    }
}
