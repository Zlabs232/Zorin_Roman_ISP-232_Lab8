namespace struct2;
internal class Program
{
    struct Person
    {
        public string name; public int age;

        public Person(string name = "Том", int age = 1) //Также возможен коструктор без параметров
        {
            this.name = name; this.age = age;
        }

        public void Print()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }
    static void Main(string[] args)
    {
        Person garen; 
        garen.name = "Гарен";
        garen.age = 25;
        garen.Print();

        Person ahri = new();
        Person brand = new("Brand");
        Person darius = new("Darius", 4);

        ahri.Print(); brand.Print(); darius.Print();

    }
}
