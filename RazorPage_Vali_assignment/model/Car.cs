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

		[Required(ErrorMessage = "Vendor is required.")]
		[StringLength(50, ErrorMessage = "Vendor name cannot exceed 50 characters.")]
		public string Vendor { get; set; }

		[Required(ErrorMessage = "Model is required.")]
		[StringLength(50, ErrorMessage = "Model name cannot exceed 50 characters.")]
		public string Model { get; set; }

		[Required(ErrorMessage = "Color is required.")]
		[StringLength(30, ErrorMessage = "Color cannot exceed 30 characters.")]
		public string Color { get; set; }

		[Required(ErrorMessage = "Odometer reading is required.")]
		[Range(0, 1000000, ErrorMessage = "Odometer must be between 0 and 1,000,000 km.")]
		public int Odometer { get; set; }

		[Required(ErrorMessage = "Engine kind is required.")]
		[Range(1, 5, ErrorMessage = "Please select a valid engine kind (1-5).")]
		public int EngineKind { get; set; }

		[Required(ErrorMessage = "Engine power is required.")]
		[Range(1, 2000, ErrorMessage = "Engine power must be between 1 and 2000 HP.")]
		public int EnginePower { get; set; }

		[Required(ErrorMessage = "Number of doors is required.")]
		[Range(1, 8, ErrorMessage = "Doors must be between 1 and 8.")]
		public int Doors { get; set; }

		// Booleans do not need [Required] because they are inherently true or false
		public bool Towbar { get; set; }

		[Required(ErrorMessage = "Year is required.")]
		[Range(1886, 2027, ErrorMessage = "Year must be between 1886 and 2027.")]
		public int Year { get; set; }

		public override string ToString()
		{
			return $"Id: {Id}, Vendor: {Vendor}, Model: {Model}, Color: {Color}, Odometer: {Odometer}, EngineKind: {EngineKind}, EnginePower: {EnginePower}, Doors: {Doors}, Towbar: {Towbar}, Year: {Year}";
		}
	}
}
