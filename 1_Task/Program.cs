namespace _1_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new("Toyota", "S35", 1945, 1830);
            myCar.PrintInfo();
            Car myCar2 = new("Mazda", "9dj8F", 2022, 1490);
            myCar2.PrintInfo();
        }
    }
}
