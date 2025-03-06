namespace WebApplication_.NET_8._0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            builder.Services.AddControllersWithViews(); // Register built in MVC
            
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            ////app.MapPost("/", () => "Hello World!");// error
            //app.MapGet("/login", Signin);

            // MVC 
            app.MapControllerRoute(
                name: "default",
                //pattern: "{controller}/{action}/{id}"
                //pattern: "mvc/hamada{controller=Movie}/{action=GetMovie}/{id=12}" // Daatype: "any" by default
                //pattern: "mvc/hamada{controller=Movie}/{action=GetMovie}/{id: alpha:length(3,4)=12}"
                //pattern: "mvc/hamada{controller=Movie}/{action=GetMovie}/{id:regex()=12}"
                pattern: "{controller=Movie}/{action=GetMovie}/{id?}"
                );
            // URL: Not Case Sensitive

            app.Run();
        }

        public static string Signin()
        {
            return $"You Are Signed In";
        }
    }
}
