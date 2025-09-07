using MyApp;
namespace _3_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User me = new User();
            me.name = "Roman";
            me.email = "z0rin.romanchik@yandex.ru";
            me.isActive = true;

            me.print();
        }
    }
}
