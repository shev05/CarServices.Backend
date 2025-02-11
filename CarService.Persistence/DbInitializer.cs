
namespace CarServices.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(CarServicesDbContext context) {
            context.Database.EnsureCreated();
        }
    }
}
