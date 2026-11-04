
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage_Vali_assignment.model;
using RazorPage_Vali_assignment.Repo;

namespace RazorValiTest.Pages
{
	public class CreateModel : PageModel
	{
		private readonly CarRepo _repo;

		public CreateModel(CarRepo repo)
		{
			_repo = repo;
		}

		public int Id { get; set; }
		[BindProperty]
		[Required(ErrorMessage = "Vendor is required")]
		public string Vendor { get; set; }
		public string Model { get; set; }
		public string Color { get; set; }
		public int Odometer { get; set; }
		public int EngineKind { get; set; }
		public int EnginePower { get; set; }
		public int Doors { get; set; }
		public bool Towbar { get; set; }
		public int Year { get; set; }


		public void OnGet()
		{
			// Renders the empty form
		}

		public IActionResult OnPost()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}
			Car newCar = new Car (Id, Vendor, Model, Color, Odometer, EngineKind, EnginePower, Doors, Towbar, Year);
			newCar = _repo.Create(newCar);
			return RedirectToPage("(Index)");
			{
				
			};

		}


	}
}
	

