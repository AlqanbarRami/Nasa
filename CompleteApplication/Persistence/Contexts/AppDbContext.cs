
using CompleteApplication.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CompleteApplication.Persistence.Contexts
{

        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
                this.Database.EnsureCreated();
            }
            public DbSet<Drone> Drones { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<Drone>().HasData(new Drone {
                 DroneId = 1,
                 DroneName = "Curiosity",
                 DroneInfo = "The Mars Science Laboratory and its rover centerpiece, " +
                 "Curiosity, is the most ambitious Mars mission yet flown by NASA." +
                 " The rover landed on Mars in 2012 with" +
                 " a primary mission to find out if Mars is, or was, " +
                 "suitable for life. Another objective is to learn more about the Red Planet's environment In March 2018",
                 DroneImage = "https://akm-img-a-in.tosshub.com/indiatoday/images/story/201708/647_080817120205.jpg?size=770:433"

                });

                modelBuilder.Entity<Drone>().HasData(new Drone
                {
                    DroneId = 2,
                    DroneName = "Opportunity",
                    DroneInfo = "Opportunity was the second of the two rovers launched in 2003 to land on Mars and begin traversing the Red Planet in search of signs of ancient water. The rover explored the Martian terrain for almost 15 years, far outlasting her planned 90-day mission."+
                    "The Opportunity rover stopped communicating with Earth when a severe Mars - wide dust storm blanketed its location in June 2018.After more than a thousand commands to restore contact, engineers in the Mission Control at NASA's Jet Propulsion Laboratory (JPL) made their last attempt to revive Opportunity Tuesday, February 13, 2019, to no avail. The solar-powered rover's final communication was received June 10.",
                    DroneImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d8/NASA_Mars_Rover.jpg/1200px-NASA_Mars_Rover.jpg"

                });

                modelBuilder.Entity<Drone>().HasData(new Drone
                {
                    DroneId = 3,
                    DroneName = "Spirit",
                    DroneInfo = "NASA's Spirit rover—and it's twin Opportunity—studied the history of climate and " +
                   " water at sites on Mars where conditions may once have been favorable to life Spirit uncovered strong evidence that Mars was once much wetter than it is now."+
                    " Described as a wonderful workhorse — Spirit operated for 6 years, 2 months, and 19 days, more than 25 times its original intended lifetime."+
                    " The rover traveled 4.8 miles (7.73 kilometers) across the Martian plains. " +
                    " On May 25, 2011, NASA ended efforts to contact the marooned rover and declared its mission complete. The rover had been silent since March 2010.",
                    DroneImage = "https://solarsystem.nasa.gov/system/content_pages/main_images/1068_rover2-1.jpg"
                });
               
            }
        }
    }

