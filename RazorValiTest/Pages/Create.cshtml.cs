
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage_Vali_assignment.model;
using RazorPage_Vali_assignment.Repo;

namespace RazorValiTest.Pages
{
	public class CreateModel : PageModel
	{
		private CarRepo _repo;

		// This constructor assumes you are initializing your repo 
		// (either via Dependency Injection or manually)
		public CreateModel(CarRepo repo)
		{
			_repo = repo;
		}

		// This attribute connects the form fields to this object
		[BindProperty]
		public Car car { get; set; }

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

			_repo.Create(car);
			return RedirectToPage("Index");

		}


	}
}
	

