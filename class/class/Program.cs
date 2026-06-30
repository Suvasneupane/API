

Console.WriteLine("Hello, World!");




class car
{
    public string brand;
    public int speed;
    public void drive()
    {
        Console.WriteLine(brand + " is driving "+ speed+"km/h");

    }
}

class program
{
    static void main()
    {
        car car1 = new car();

        car1.brand = "Toyata"; // value assigning 
        car1.speed = 120;

        car1.drive();  // calling 

    }
}