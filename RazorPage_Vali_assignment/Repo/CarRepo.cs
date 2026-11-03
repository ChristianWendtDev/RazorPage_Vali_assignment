using System;
using System.Collections.Generic;
using System.Text;
using RazorPage_Vali_assignment.model;
namespace RazorPage_Vali_assignment.Repo
{
	public class CarRepo
	{
		private List<Car> _cars;

		public CarRepo()
		{
			_cars = new List<Car>();
		}
		public CarRepo(List<Car> cars)
		{
			_cars = cars;
		}

		public List<Car> Cars
		{ get { return _cars; } set { _cars = value; } }


		public Car GetById (int id)
		{
			foreach (Car car in _cars)
			{
				if (car.Id == id)
				{
					return car;
				}
			}
			return null;
		}
		public Car Create(Car car)
		{
			_cars.Add(car);
			return car;
		}

		public List<Car> ReadAll()
		{
			return new List<Car>(_cars);
		}

		public void Delete(int id)
		{
			Car CarToRemove = GetById(id);
			_cars.Remove(CarToRemove);
		}

		public Car Update(Car car)
		{
			Car CarToUpdate = GetById(car.Id);
			if (CarToUpdate != null)
			{
				CarToUpdate.Vendor = car.Vendor;
				CarToUpdate.Model = car.Model;
				CarToUpdate.Color = car.Color;
				CarToUpdate.Odometer = car.Odometer;
				CarToUpdate.EngineKind = car.EngineKind;
				CarToUpdate.EnginePower = car.EnginePower;
				CarToUpdate.Doors = car.Doors;
				CarToUpdate.Towbar = car.Towbar;
				CarToUpdate.Year = car.Year;
			}
			return CarToUpdate;
		}



	}
}

