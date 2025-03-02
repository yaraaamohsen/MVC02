namespace WebApplication2_V6._0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Register Any Service 
            builder.Services.AddControllersWithViews();
            builder.Services.AddControllers();


            var app = builder.Build();
            // Add Any Configuring For MiddleWare 

            app.UseRouting();

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
