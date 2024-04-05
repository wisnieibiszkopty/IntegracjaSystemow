namespace IS_Lab8_JWT;

public class Program
{
    public static void Main(string[] args)
    {
        // var builder = WebApplication.CreateBuilder(args);
        // var app = builder.Build();
        //
        // app.MapGet("/", () => "Hello World!");
        // app.MapGet("/test", () => "test");
        //
        // app.Run();
        
        CreateHostBuilder(args).Build().Run();
    }
    
    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>().UseUrls("http://localhost:8080");
            });
}