using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using PineoTest.Models;
using Microsoft.EntityFrameworkCore;

namespace PineoTest
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<HelloWorldContext>(opt =>
                opt.UseInMemoryDatabase("HelloWorld"));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_0);

            services.Configure<ApiBehaviorOptions>(options =>
                  {
                      options.SuppressConsumesConstraintForFormFileParameters = true;
                      options.SuppressInferBindingSourcesForParameters = true;
                      options.SuppressModelStateInvalidFilter = true;
                  });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }
}
