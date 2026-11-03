using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage_Vali_assignment.Repo;
using RazorPage_Vali_assignment.model;

namespace RazorValiTest.Pages
{
	public class IndexModel(CarRepo carRepo) : PageModel
	{
		private readonly CarRepo _carRepo = carRepo;

		public List<Car> Cars { get; private set; } = [];

		public void OnGet()
		{
			Cars = _carRepo.ReadAll();
		}
	}
}
