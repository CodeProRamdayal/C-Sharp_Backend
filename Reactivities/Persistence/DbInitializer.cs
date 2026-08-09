using System;
using Domain;

namespace Persistence;

public class DbInitializer
{
    public static async Task SeedData(AppDbContext context)
    {
        if (context.Activities.Any()) return;

        var activities = new List<Activity>
        {
            new Activity
            {
                Title = "Hiking Adventure",
                Date = new DateTime(2026, 8, 15),
                Description = "A fun hiking trip through scenic mountain trails.",
                Category = "Hiking",
                IsCancelled = false,
                City = "Pune",
                Venue = "Sinhagad Fort",
                Latitude = 18.3663,
                Longitude = 73.7559
            },

            new Activity
            {
                Title = "Cricket Tournament",
                Date = new DateTime(2026, 8, 20),
                Description = "Friendly cricket tournament for local teams.",
                Category = "Sports",
                IsCancelled = false,
                City = "Mumbai",
                Venue = "Wankhede Stadium",
                Latitude = 18.9389,
                Longitude = 72.8258
            },

            new Activity
            {
                Title = "Photography Walk",
                Date = new DateTime(2026, 8, 25),
                Description = "Explore the city and capture interesting architectural and street photographs.",
                Category = "Photography",
                IsCancelled = false,
                City = "Pune",
                Venue = "Shaniwar Wada",
                Latitude = 18.5196,
                Longitude = 73.8553
            },

            new Activity
            {
                Title = "Tech Meetup",
                Date = new DateTime(2026, 9, 5),
                Description = "A meetup for developers to discuss modern web development and cloud technologies.",
                Category = "Technology",
                IsCancelled = false,
                City = "Bengaluru",
                Venue = "Koramangala",
                Latitude = 12.9352,
                Longitude = 77.6245
            },

            new Activity
            {
                Title = "Cooking Workshop",
                Date = new DateTime(2026, 9, 10),
                Description = "Learn how to prepare traditional Indian dishes with an experienced chef.",
                Category = "Cooking",
                IsCancelled = true,
                City = "Delhi",
                Venue = "Connaught Place",
                Latitude = 28.6315,
                Longitude = 77.2167
            }
        };
        context.Activities.AddRange(activities);
        await context.SaveChangesAsync();
    }

}
