using System;
using Day08Assignment.Part2;

namespace Day08Assignment
{
    internal class Program
    {

        #region Part2Problem
        static void PrintTenShapes(IShapeSeries series)
        {
            series.ResetSeries();

            for (int i = 0; i < 10; i++)
            {
                series.GetNextArea();

                Console.WriteLine(series.CurrentShapeArea);
            }
        } 
        #endregion

        static void Main(string[] args)
        {
            #region Problem1
            //IVehicle car = new Car();
            //IVehicle bike = new Bike();

            //car.StartEngine();
            //car.StopEngine();

            //bike.StartEngine();
            //bike.StopEngine(); 
            #endregion

            #region Problem2
            //Shape rectangle = new Rectangle(5, 4);
            //Shape circle = new Circle(3);

            //rectangle.Display();
            //Console.WriteLine("Rectangle Area = " + rectangle.GetArea());

            //circle.Display();
            //Console.WriteLine("Circle Area = " + circle.GetArea()); 
            #endregion

            #region Problem3
            //Product[] products =
            //{
            //    new Product(1, "Laptop", 30000),
            //    new Product(2, "Mouse", 500),
            //    new Product(3, "Keyboard", 1500),
            //    new Product(4, "Monitor", 7000)
            //};

            //Array.Sort(products);

            //foreach (Product product in products)
            //{
            //    Console.WriteLine(product);
            //} 
            #endregion

            #region Problem4
            //Address address = new Address("Sohag");

            //Student student1 = new Student(
            //    1,
            //    "Ebrahim",
            //    90,
            //    address
            //);


            //Student student2 = new Student(student1);

            //student2.Name = "Ahmed";
            //student2.Address.City = "Cairo";

            //Console.WriteLine("Original Student:");
            //Console.WriteLine(student1.Name);
            //Console.WriteLine(student1.Address.City);

            //Console.WriteLine();

            //Console.WriteLine("Copied Student:");
            //Console.WriteLine(student2.Name);
            //Console.WriteLine(student2.Address.City); 
            #endregion

            #region Problem5
            //Robot robot = new Robot();

            //robot.Walk();

            //IWalkable walkable = robot;

            //walkable.Walk(); 
            #endregion

            #region Problem6
            //Account account = new Account();

            //account.Id = 1001;
            //account.Holder = "Ebrahim";
            //account.AccountBalance = 5000;

            //Console.WriteLine("Account ID: " + account.Id);
            //Console.WriteLine("Account Holder: " + account.Holder);
            //Console.WriteLine("Balance: " + account.AccountBalance); 
            #endregion

            #region Problem7
            //ILogger logger = new ConsoleLogger();
            //logger.Log();
            #endregion

            #region Problem8
            //Book book1 = new Book();

            //Book book2 = new Book("Clean Code");

            //Book book3 = new Book("Clean Code", "Robert C. Martin");

            //book1.Display();
            //book2.Display();
            //book3.Display(); 
            #endregion



            ///////Part 2


            #region Problem1
            //IShapeSeries squareSeries = new SquareSeries();

            //Console.WriteLine("Square Series:");
            //PrintTenShapes(squareSeries);

            //Console.WriteLine();

            //IShapeSeries circleSeries = new CircleSeries();

            //Console.WriteLine("Circle Series:");
            //PrintTenShapes(circleSeries); 
            #endregion

            #region Problem2
            //Day08Assignment.Part2.Shape[] shapes =
            //{
            //    new Day08Assignment.Part2.Shape("Square", 25),
            //    new Day08Assignment.Part2.Shape("Circle", 12.5),
            //    new Day08Assignment.Part2.Shape("Rectangle", 40),
            //    new Day08Assignment.Part2.Shape("Circle", 8),
            //    new Day08Assignment.Part2.Shape("Square", 16)
            //};

            //Array.Sort(shapes);

            //foreach (Day08Assignment.Part2.Shape shape in shapes)
            //{
            //    Console.WriteLine(shape);
            //} 
            #endregion

            #region Problem3
            //Day08Assignment.Part2.Triangle triangle =
            //new Day08Assignment.Part2.Triangle(10, 5);

            //Day08Assignment.Part2.Rectangle rectangle =
            //    new Day08Assignment.Part2.Rectangle(10, 5);

            //Console.WriteLine("Triangle Area: " + triangle.CalculateArea());
            //Console.WriteLine("Triangle Perimeter: " + triangle.Perimeter);

            //Console.WriteLine();

            //Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());
            //Console.WriteLine("Rectangle Perimeter: " + rectangle.Perimeter); 
            #endregion

            #region Problem4
            //int[] shapeAreas =
            //{
            //    50,
            //    25,
            //    40,
            //    10,
            //    80,
            //    30
            //};

            //SortingHelper.SelectionSort(shapeAreas);

            //Console.WriteLine("Sorted Shape Areas:");

            //foreach (int area in shapeAreas)
            //{
            //    Console.WriteLine(area);
            //} 
            #endregion

        }
    }
}
