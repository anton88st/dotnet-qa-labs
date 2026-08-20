namespace ProgrammingTasks_answers.Array
{
    public class ArrayTasks(IArrayTask arrayTask)
    {
        private readonly IArrayTask _arrayTask = arrayTask;

        public void ExecuteTask()
        {
            _arrayTask.Execute();
        }
    }
}
