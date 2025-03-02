namespace FullProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();  // Register Built-in MVC Services

            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            ////app.MapGet("/login", () => "U Are Signed In!");
            //app.MapGet("/login", SignIn);

            app.UseStaticFiles(); // Add MiddleWare Of Static Files 

            // MVC

            app.MapControllerRoute
            (
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
            );
            app.Run();
        }

        public static string SignIn()
        {
            return $"U Are Signed In!";
        }
    }
}
