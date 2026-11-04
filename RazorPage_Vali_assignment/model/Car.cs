using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RazorPage_Vali_assignment.model
{
	public class Car
	{
		private int _id;
		private string _vendor;
		private string _model;
		private string _color;
		private int _odometer;
		private int _engineKind;
		private int _enginePower;
		private int _doors;
		private bool _towbar;
		private int _year;

		public Car ()
		{
			_id=0;
			_vendor="";
			_model="";
			_color="";
			_odometer=0;
			_engineKind=0;
			_enginePower=0;
			_doors=0;
			_towbar=false;
			_year=0;
		}
		public Car (int id, string vendor, string model, string color, int odometer, int engineKind, int enginePower, int doors, bool towbar, int year)
		{
			Id = id;
			Vendor = vendor;
			Model = model;
			Color = color;
			Odometer = odometer;
			EngineKind = engineKind;
			EnginePower = enginePower;
			Doors = doors;
			Towbar = towbar;
			Year = year;
		}


		public int Id { get; set; }
		public string Vendor { get; set; }
		public string Model { get; set; }
		public string Color { get; set; }
		public int Odometer { get; set; }
		public int EngineKind { get; set; }
		public int EnginePower { get; set; }
		public int Doors { get; set; }
		public bool Towbar { get; set; }
		public int Year { get; set; }

		public override string ToString()
		{
			return $"Id: {Id}, Vendor: {Vendor}, Model: {Model}, Color: {Color}, Odometer: {Odometer}, EngineKind: {EngineKind}, EnginePower: {EnginePower}, Doors: {Doors}, Towbar: {Towbar}, Year: {Year}";
		}
	}
}
