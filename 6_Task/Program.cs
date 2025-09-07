class Rectangle
{
    private double _width;
    private double _height;
    public double Width
    {
        get { return _width; }
        set
        {
            if (value <= 0)
                _width = 1; 
            else
                _width = value;
        }
    }

    public double Height
    {
        get { return _height; }
        set
        {
            if (value <= 0)
                _height = 1; 
            else
                _height = value;
        }
    }

    public double Area
    {
        get { return _width * _height; }
    }

    public Rectangle(double width, double height)
    {
        Width = width; 
        Height = height; 
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Ширина: {Width}, Высота: {Height}, Площадь: {Area}");
    }

    static void Main(string[] args)
    {
        Rectangle rect1 = new Rectangle(5, 10);
        rect1.PrintInfo(); 

        Rectangle rect2 = new Rectangle(-2, 0);
        rect2.PrintInfo(); 
    }
}