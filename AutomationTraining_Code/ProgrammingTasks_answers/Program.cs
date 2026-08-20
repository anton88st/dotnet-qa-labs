using ProgrammingTasks_answers.Array;
using ProgrammingTasks_answers.ConditionOperator;
using ProgrammingTasks_answers.ConditionOperator.ConditionTasks;
using ProgrammingTasks_answers.InputOutput;
using ProgrammingTasks_answers.LoopOperator;
using ProgrammingTasks_answers.Matrics;

namespace ProgrammingTasks_answers;

class Program
{
    static void Main(string[] args)
    {
        GeneralMethods.output = new ConsoleOutput();

        ConditionOperatorTasks();
        LoopOperatorTasks();
        Massive();
        Matrics();

    }

    public static void ConditionOperatorTasks()
    {
        new ConditionOperatorTasks(new FirstTask()).ExecuteTask();
        new ConditionOperatorTasks(new SecondTask()).ExecuteTask();
        new ConditionOperatorTasks(new ThirdTask()).ExecuteTask();
        new ConditionOperatorTasks(new FourthTask()).ExecuteTask();
        new ConditionOperatorTasks(new FifthTask()).ExecuteTask();
        new ConditionOperatorTasks(new SixthTask()).ExecuteTask();
        new ConditionOperatorTasks(new SeventhTask()).ExecuteTask();
    }

    public static void LoopOperatorTasks()
    {
        new LoopOperatorTasks(new FirstTask_for()).ExecuteTask();
        new LoopOperatorTasks(new SecondTask_for()).ExecuteTask();
        new LoopOperatorTasks(new ThirdTask_for()).ExecuteTask();
        new LoopOperatorTasks(new FourthTask_for()).ExecuteTask();
        new LoopOperatorTasks(new FifthTask_for()).ExecuteTask();
        new LoopOperatorTasks(new SixthTask_for()).ExecuteTask();
        new LoopOperatorTasks(new SeventhTask_for()).ExecuteTask();
        new LoopOperatorTasks(new EighthTask_for()).ExecuteTask();
    }

    public static void Massive()
    {
        new ArrayTasks(new ArrayFirstTask()).ExecuteTask();
        new ArrayTasks(new ArraySecondTask()).ExecuteTask();
        new ArrayTasks(new ArrayThirdTask()).ExecuteTask();
    }

    public static void Matrics()
    {
        new MatrixTasks(new Task1()).ExecuteTask();
        new MatrixTasks(new Task2()).ExecuteTask();
        new MatrixTasks(new Task3()).ExecuteTask();
        new MatrixTasks(new Task4()).ExecuteTask();
        new MatrixTasks(new Task5()).ExecuteTask();
    }
}