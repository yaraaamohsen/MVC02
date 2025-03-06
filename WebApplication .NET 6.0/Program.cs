namespace WebApplication_.NET_6._0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args); // Built In Here
            // Register Any Services
            builder.Services.AddControllersWithViews();


            var app = builder.Build();
            // Register Any Middleware
            app.UseRouting();


            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
