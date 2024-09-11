namespace Vehicle_Infor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" What type of vehicle do you have?: ");
            string vehicleType = Console.ReadLine();

            Console.WriteLine(" Please enter car brand: ");
            string carBrand = Console.ReadLine();

            Console.WriteLine(" Please enter car model: ");
            string carModel = Console.ReadLine();

            Console.WriteLine(" Please car year: ");
            int carYear = int.Parse(Console.ReadLine());

            Console.WriteLine(" Please enter car Licence plate: ");
            string carLicence = Console.ReadLine();

            Car theeCar = new Car
            {
                Brand = carBrand,
                Model = carModel,
                Year = carYear,
                Licence = carLicence,
                typeOfVehicle = vehicleType
            };

            Vehicle theeVehicle = theeCar;

            //Console.WriteLine(" Vehicle kind: " + theeVehicle.Type);
            Console.WriteLine(" Vehicle information: " + "\n" + theeVehicle.Name);


            Console.ReadLine();
        }
    }
}
public class Vehicle
{
    //public string Type { get; set; }
    public string Name { get; set; }
}

public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Licence { get; set; }
    public string typeOfVehicle { get; set; }

    public static implicit operator Vehicle(Car car)
    {
        return new Vehicle
        {
            //Type = car.typeOfVehicle,
            Name = " The type of vehicle is: " + car.typeOfVehicle + "\n" + " Vehicle brand is: " + car.Brand + "\n" + " Vehicle model is: " + car.Model + "\n" + " Veicle year is: " + car.Year + "\n" + " Vehicle licence plate is: " + car.Licence ,
        };

    }
}
