namespace Hero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Боб", 120);
            Console.WriteLine($"Имя героя: {hero.Name}\nУровень героя: {hero.Level}\nМана: {hero.Mana}\nСтатус: {hero.Status}");

            hero.TakeDamage(30);
            hero.Heal(30);
            hero.TakeDamage(3000);
            hero.Heal(50);
        }
    }
}
