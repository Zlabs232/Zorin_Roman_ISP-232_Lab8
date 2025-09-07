namespace _1_Task
{
    internal class Car
    {
        private string Brand {  get; set; }
        private string Model { get; set; }
        private int Year { get; set; }
        private int Mileage { get; set; } 

        public Car(string brand, string model, int year, int mileage)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Бренд: {Brand}, Модель: {Model}, Год выпуска: {Year}, Пробег: {Mileage}");
        }
    }
}
