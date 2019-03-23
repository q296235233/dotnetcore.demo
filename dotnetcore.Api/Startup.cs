using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetcore.core;
using dotnetcore.core.Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace dotnetcore.Api
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) //服务 集合 启动方法  
        {
            //services.AddScoped<ILogger, Logger>();

            services.AddMvc();


            // 
            services.AddDbContext<UserContext>(options => options.UseMySql(@"server=localhost;Initial Catalog=user_demo;Persist Security Info=True;User ID=root;Password=123456;"));
            //服务添加上下问  选择 Mysql进行显示操作
            services.AddScoped<IUserVisit, UserVisit>();//服务范围 
        }

        // 管道
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())   //进行是生产  不会出页面异常
            {
                app.UseDeveloperExceptionPage();
            }



         // 静态文件
            app.UseStaticFiles();



           

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
