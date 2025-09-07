using Base;
//global using Base - использование пространства имён для всех файлов. Если много имён - лучше создать отдельный файл, где они будут подключаться на все работы
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
