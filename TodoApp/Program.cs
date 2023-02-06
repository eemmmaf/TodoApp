namespace TodoApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Aktiverar MVC
            builder.Services.AddControllersWithViews();

            builder.Services.AddDistributedMemoryCache();
           
            var app = builder.Build();

            //Aktiverar möjlighet att använda statiska filer
            app.UseStaticFiles();

            //Aktiverar routing
            app.UseRouting();


            //Skapar routing
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );

            app.Run();
        }
    }
}