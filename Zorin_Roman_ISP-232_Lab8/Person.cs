class Person
{
    private string name = "Undefined";
    private int age = 1;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value < 1 || value > 120)
                Console.WriteLine("Диапазон возраста: (1 - 120)");
            else
                age = value;
        }
    }
}