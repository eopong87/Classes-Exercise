namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
          
            Car Mycar = new Car();
            Mycar.Make = "Nissan";
            Mycar.model = "Altima";
            Mycar.year = 2023;

            Console.WriteLine(Mycar.Make);
            Console.WriteLine(Mycar.model);
            Console.WriteLine(Mycar.year);

        }
    }

} 

