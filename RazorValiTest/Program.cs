


using RazorPage_Vali_assignment.Repo;
using RazorPage_Vali_assignment.model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

CarRepo ListofCars = new CarRepo(new List<Car>
{
	new Car(1, "Volvo", "XC90", "Black", 10000, 1, 200, 5, true, 2020),
	new Car(2, "Ford", "Mustang", "Red", 5000, 2, 300, 2, false, 2021),
	new Car(3, "Toyota", "Camry", "Blue", 20000, 1, 150, 4, false, 2019),
	new Car(4, "Tesla", "Model 3", "White", 12000, 3, 283, 4, false, 2022),
	new Car(5, "Volkswagen", "Golf", "Gray", 35000, 1, 150, 5, true, 2018)


});


builder.Services.AddSingleton(ListofCars);


var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
