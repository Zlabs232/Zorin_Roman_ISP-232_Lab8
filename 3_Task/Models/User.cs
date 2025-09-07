namespace MyApp
{
    internal class User
    {
        public string name {  get; set; }
        public string email { get; set; }
        public bool isActive { get; set; }

        public void print() => Console.WriteLine($"Имя: {name}, почта: {email}, В сети: {(isActive == true ? "Да" : "Нет")}");
    }
}
