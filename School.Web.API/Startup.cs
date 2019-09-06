using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using School.Common.Settings;
using School.Domain.Core;
using School.Repositories.SqlServer;
using School.Service.Core;
using School.Services;
using Section.Service.Core;
using Section.Services;
using Signature.Repositories.SqlServer;
using Signature.Services;
using Teacher.Repositories.SqlServer;
using Teacher.Services;

namespace School.Web.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<SqlDbContext>(ServiceLifetime.Scoped);
            services.AddTransient<ISchoolRepository,SchoolRepository>();
            services.AddTransient<ITeacherRepository, TeacherRepository>();
            services.AddTransient<ISectionRepository, SectionRepository>();
            services.AddTransient<ISignatureRepository, SignatureRepository>();
            services.AddTransient<ISchoolService,SchoolService>();
            services.AddTransient<ITeacherService, TeacherService>();
            services.AddTransient<ISignatureService, SignatureService>();
            services.AddTransient<ISectionService, SectionService>();
            services.Configure<DbSettings>(Configuration.GetSection("SqlDbSettings"));
            var mapperConfig = new MapperConfiguration(opt =>
            {
                opt.AddProfile<School.Services.Automapper.MapperProfile>();
            });
            services.AddSingleton(d=> mapperConfig.CreateMapper());
            //Just for test Vue Js App should not do it on Production
            services.AddCors(r =>
            {
                r.AddPolicy("AllowAll", policy => {
                    policy.AllowAnyOrigin();
                    policy.AllowAnyMethod();
                    policy.AllowAnyHeader();
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseCors("AllowAll");
            app.UseMvc();
        }
    }
}
