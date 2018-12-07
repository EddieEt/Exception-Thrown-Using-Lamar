using Lamar;

namespace WebApplication2
{
    public class WebApplicationRegistry : ServiceRegistry
    {
        public WebApplicationRegistry()
        {
            this.For(typeof(IRepository<>)).Use(typeof(TestRepository<>));
        }
    }
}