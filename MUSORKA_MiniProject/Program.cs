namespace MUSORKA_MiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var apple = new Product { Name = "Яблоко", Price = 10.5m, Quantity = 5 };
            var banana = new Product { Name = "Банан", Price = 7.2m, Quantity = -2 };


            Console.WriteLine($"{apple.Name} x {apple.Quantity} = {apple.TotalPrice} Руб.");
            Console.WriteLine($"{banana.Name} x {banana.Quantity} = {banana.TotalPrice} Py6.");  //Значение 0 — потому что Quantity = -2, а в программе в сеттере указано, что при отрицательных значениях значение quantity устанавливается на 0.Следовательно, умножение на 0 = 0.
        }
    }
}
