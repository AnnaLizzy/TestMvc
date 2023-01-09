using FluentValidation;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;
using System.Globalization;
using System.Reflection;
using ViewModel.System;
using WebApi.Models.System;
using WebApp.Areas.Admin.Models;
using WebApp.Models;

namespace WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            //Jsson Localization 
            //builder.Services.AddLocalization();

            //builder.Services.AddSingleton<IStringLocalizerFactory, JsonStringLocalizerFactory>();

            //builder.Services.AddMvc().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
            //    .AddDataAnnotationsLocalization(options =>
            //    {
            //        options.DataAnnotationLocalizerProvider = (type, factory) =>
            //        factory.Create(typeof(JsonStringLocalizerFactory));
            //    });
            //builder.Services.Configure<RequestLocalizationOptions>(options =>
            //{
            //    var suppotedCulture = new[]
            //    {
            //        new CultureInfo ("vi-VN"),
            //        new CultureInfo ("en-US"),
            //        new CultureInfo ("zh-CN"),

            //    };
            //    options.DefaultRequestCulture = new RequestCulture(culture: suppotedCulture[0], uiCulture: suppotedCulture[0]);
            //    options.SupportedCultures = suppotedCulture;
            //    options.SupportedUICultures= suppotedCulture;
            //});

            /*        DI localization              */
            builder.Services.AddSingleton<LanguageService>();

            builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

            builder.Services.AddMvc()
                .AddViewLocalization()
                .AddDataAnnotationsLocalization(options =>
                {
                    options.DataAnnotationLocalizerProvider = (type, factory) =>
                    {

                        var assemblyName = new AssemblyName(typeof(Resource).GetTypeInfo().Assembly.FullName);

                        return factory.Create("Resource", assemblyName.Name);

                    };

                });
            /* end */
            builder.Services.Configure<RequestLocalizationOptions>(
               options =>
               {
                   var supportedCultures = new List<CultureInfo>
                       {
                            new CultureInfo("vi-VN"),
                            new CultureInfo("en-US"),
                            new CultureInfo("zh-CN"),
                       };



                   options.DefaultRequestCulture = new RequestCulture(culture: "vi-VN", uiCulture: "vi-VN");

                   options.SupportedCultures = supportedCultures;
                   options.SupportedUICultures = supportedCultures;
                   options.RequestCultureProviders.Insert(0, new QueryStringRequestCultureProvider());

               });
           

            //
            builder.Services.AddHttpClient(); 

            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
               .AddCookie(options =>
               {
                   options.LoginPath = "/Account/Login";
                   options.AccessDeniedPath = "/AccessDeni";
               });

            builder.Services.AddDistributedMemoryCache();           // Đăng ký dịch vụ lưu cache trong bộ nhớ (Session sẽ sử dụng nó)
            builder.Services.AddSession(cfg =>
            {                    // Đăng ký dịch vụ Session
                cfg.Cookie.Name = "Test";             // Đặt tên Session - tên này sử dụng ở Browser (Cookie)
                cfg.IdleTimeout = TimeSpan.FromMinutes(30);    // Thời gian tồn tại của Session
            });

            builder.Services.AddControllersWithViews();
            //DI
            builder.Services.AddTransient<IUserApiClient,UserApiClient>();

            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            builder.Services.AddTransient<IValidator<LoginRequest>, LoginRequestValidator>();
            builder.Services.AddTransient<IValidator<RegisterRequest>, RegisterRequestValidator>();



            builder.Services.AddRazorPages();

            var app = builder.Build();
            // config localization
            var locOptions = ((IApplicationBuilder)app).ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();

            app.UseRequestLocalization(locOptions.Value);
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseSession();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            //var supportedCulture = new[] { "vi-VN", "en-US", "zh-CN" };
            //var localizationOptions = new RequestLocalizationOptions()
            //    .SetDefaultCulture(supportedCulture[0])
            //    .AddSupportedCultures(supportedCulture)
            //    .AddSupportedUICultures(supportedCulture);
            //app.UseRequestLocalization(localizationOptions);



            app.UseAuthentication();
            app.UseAuthorization();

            app.MapAreaControllerRoute(
            name: "MyArea",
            areaName: "Admin",
            pattern: "Admin/{controller=Manager}/{action=Index}/{id?}");



            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}