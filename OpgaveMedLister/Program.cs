using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgaveMedLister
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listTal = new List<int>() { 4, 7, 12, 17, -3, 8, 0, -45, 101 };

            List<int> nyListe1 = listTal.Where(number => number <= 0).ToList();
            List<int> nyListe2 = listTal.Where(number => number == 7).ToList();
            List<int> nyListe3 = listTal.Where(number => number > 4).ToList();

            UdskrivListe(listTal);
            UdskrivListe(nyListe2);

            List<Car> cars = new List<Car>
            {
                new Car(1, "Rio", "Kia", 2006, 250000, "Red"),
                new Car(2, "Rio", "Kia", 2007, 265000, "Black"),
                new Car(3, "Panda", "Fiat", 2017, 256000, "Black"),
                new Car(4, "Panda", "Fiat", 2017, 365000, "Yellow"),
                new Car(5, "S40", "Volvo", 2018, 665000, "White"),
                new Car(6, "S65", "Volvo", 2018, 600000, "White"),
                new Car(7, "Gorm", "Ferrari", 2000, 4665000, "White"),
                new Car(8, "Gorm", "Ferrari", 2018, 4665000, "White"),
            };

            List<Car> modelRio = cars.Where(car => car.Model == "Rio").ToList();
            List<Car> brandFerrari = cars.Where(car => car.Brand == "Ferrari").ToList();
            List<Car> modelYear = cars.Where(car => car.Year >= 2010).ToList();
            List<Car> carColor = cars.Where(car => car.Color == "White").ToList();
            Car carID8 = cars.SingleOrDefault(car => car.ID == 8);


            UdskrivListe(carID8);
            Console.ReadKey(true);
        }
        static void UdskrivListe (List<int> input)
        {
            foreach(var item in input)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static void UdskrivListe(Car car)
        {
            Console.WriteLine($"ID: {car.ID}. Model: {car.Model}. Brand: {car.Brand}. " +
                $"Year: {car.Year}. Price: {car.Price}. Color: {car.Color}");
        }
    }
}
