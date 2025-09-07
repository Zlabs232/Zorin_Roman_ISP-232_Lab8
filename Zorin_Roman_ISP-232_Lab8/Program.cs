namespace Zorin_Roman_ISP_232_Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Ivan";

            person.Age = 37;
            Console.WriteLine(person.Age);
        }
    }
}
