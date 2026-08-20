namespace ProgrammingTasks_answers.Matrics
{
    public class MatrixTasks(IMatrixTask matrixTask)
    {
        private readonly IMatrixTask _matrixTask = matrixTask;

        public void ExecuteTask()
        {
            _matrixTask.Execute();
        }
    }
}
