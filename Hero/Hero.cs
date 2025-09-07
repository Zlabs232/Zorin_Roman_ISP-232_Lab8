namespace Hero
{
    internal class Hero
    {
        public string Name { get; set; }
        public int Mana { get; set; }
        public int Level { get; set; }

        private int _health;
        private int _maxHealth;

        public Hero(string name, int maxHealth)
        {
            Name = name;
            _maxHealth = maxHealth;
            _health = maxHealth;
            Mana = 100;
            Level = 1;
        }

        public int Health
        {
            get { return _health; }
            set
            {
                if (value < 0)
                    _health = 0;
                else if (value > _maxHealth)
                    _health = _maxHealth;
                else
                    _health = value;
            }
        }

        public string Status => _health > 0 ? "Жив" : "Сдох";

        public void TakeDamage(int damage)
        {
            if (_health <= 0)
            {
                Console.WriteLine($"{Name} уже сдох и не может получать урон");
                return;
            }
            Health -= damage;
            Console.WriteLine($"{Name} получает {damage} урона. HP: {Health} | Статус: {Status}");
            if (_health <= 0)
                Console.WriteLine($"{Name} сдох!");
        }

        public void Heal(int amount)
        {
            if(_health <= 0)
            {
                Console.WriteLine($"{Name} погиб, он не может быть исцелен");
                return;
            }
            Health += amount;
            Console.WriteLine($"{Name} исцелен на {amount}. HP: {Health} | Статус: {Status}");

        }
    }
}
