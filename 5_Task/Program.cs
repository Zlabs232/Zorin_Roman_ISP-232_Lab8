namespace _5_Task
{
    class System
    {
        public void MyMethod()
        {
            Console.WriteLine("Hello World!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Hello");
            //Ошибка, потому что есть глобал System из .NET и в наш клас System
            global::System.Console.WriteLine("Hello World!");

            System mySystem = new System(); 
            mySystem.MyMethod();
        }
    }
}
