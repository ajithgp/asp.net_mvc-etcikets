using etcikets.Models;
using System.Linq;

namespace etcikets.Data
{
    public class AppDataDb
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var servicescope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = servicescope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>{
                        new Cinema()
                        {
                         CinemaName="Vetri Cinemas",
                         Logo="",
                         Description="Description for Vetri Cinema"
                        }
                });
                    context.SaveChanges();
            }

                
                ////Actor
                //if (!context.Actors.Any())
                //{

                //}
                ////Movie
                //if (!context.Movies.Any())
                //{

                //}
                ////Producers
                //if (!context.Producers.Any()) 
                //{

                //}
                ////Actor and movies
                //if (!context.Actor_Movie.Any())
                //{

                //}
            }


        }
    }
}
