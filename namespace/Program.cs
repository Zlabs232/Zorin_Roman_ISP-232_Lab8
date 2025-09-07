using Base;
namespace namespace2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Base.Person tom = new("Tom");

        }
    }
}

namespace Base
{
    class Person
    {
        string name;
        public Person(string name)
        {
            this.name = name;
        }
        public void Print() => Console.WriteLine($"Имя: {name}");
    }
}
