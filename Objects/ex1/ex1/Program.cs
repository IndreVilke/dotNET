class Car
{
    string color = "red";
    int year = 2010;

    static void Main(string[] args)
    {
        Car myObj = new Car();
        Console.WriteLine("What is the color of car?");
        myObj.color = Console.ReadLine();
        Console.WriteLine("When the car was build?");
        myObj.year = Int32.Parse(Console.ReadLine());   

        Console.WriteLine(myObj.color);
        Console.WriteLine(myObj.year);
    }
}
