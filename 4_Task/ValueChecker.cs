namespace _4_Task
{
    internal class ValueChecker
    {
        public void CheckType(object value)
        {
            string typeName = value.GetType().Name;
            string category = value is ValueType ? "значимый" : "ссылочный";

            Console.WriteLine($"{category} тип ({typeName})");
        }
    }
}