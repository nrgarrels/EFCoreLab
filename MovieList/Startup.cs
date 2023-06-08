using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using MovieList.Models;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;



    }
    public IConfiguration Configuration { get; }
    public void ConfigureServices(IServiceCollection services)
    {
       services.AddDbContext<MovieContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MovieContext")));
        services.AddRouting(options => {
            options.LowercaseUrls = true; 
            options.AppendTrailingSlash = true;
        });

       // app.UseEndpoints(endpoints => {
       //     endpoints.MapControllerRoute(name: "default",
        //    pattern: "{controller=Home}/{action=Index}/{id?}/{slug?}");
      //  });

    }

}

