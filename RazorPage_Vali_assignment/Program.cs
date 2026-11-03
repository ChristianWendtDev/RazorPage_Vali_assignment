using RazorPage_Vali_assignment.model;
using RazorPage_Vali_assignment.Repo;

Console.WriteLine("Hello, World!");

Car Volve = new Car(1, "Volve", "XC90", "Black", 10000, 1, 200, 4, true, 2020);
Car Ford = new Car(2, "Ford", "Mustang", "Red", 5000, 2, 300, 2, false, 2021);
Car Toyota = new Car(3, "Toyota", "Camry", "Blue", 20000, 1, 150, 4, false, 2019);

CarRepo ListofCars = new CarRepo();

ListofCars.Create(Volve);
ListofCars.Create(Ford);
ListofCars.Create(Toyota);

foreach (Car car in ListofCars.ReadAll())
{
	Console.WriteLine(car.ToString());
}