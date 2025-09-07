namespace _4_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValueChecker checker = new ValueChecker();
            checker.CheckType(5);
            checker.CheckType("Hello");
        }
    }
}
