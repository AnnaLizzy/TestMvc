
using Applications.User;
using Data.Migration.Models.DbContext;
using Data.Migration.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using ViewModel.System;
using WebApi.Models.System;
using FluentValidation;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add Connection string
            builder.Services.AddDbContext<CertificateDBContext>(options =>
                    options.UseSqlServer("Server = SECQV0510589; Database = CertificateDB; Trusted_Connection = True;TrustServerCertificate=True;"));

            //DI
            builder.Services.AddIdentity<UserBeforeLoding, AdminRole>()
               .AddEntityFrameworkStores<CertificateDBContext>()
               .AddDefaultTokenProviders();


            builder.Services.AddTransient<IUserService, UserService>();
            builder.Services.AddTransient<UserManager<UserBeforeLoding>, UserManager<UserBeforeLoding>>();
            builder.Services.AddTransient<SignInManager<UserBeforeLoding>, SignInManager<UserBeforeLoding>>();
            builder.Services.AddTransient<RoleManager<AdminRole>, RoleManager<AdminRole>>();

            builder.Services.AddTransient<IValidator<LoginRequest>, LoginRequestValidator>();
            builder.Services.AddTransient<IValidator<RegisterRequest>, RegisterRequestValidator>();

            // Add services to the container.


            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Swagger WebCore 7.0", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = @"JWT Authorization header using the Bearer scheme. 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      Example: 'Bearer 12345abcdef'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                  {
                    {
                      new OpenApiSecurityScheme
                      {
                        Reference = new OpenApiReference
                          {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                          },
                          Scheme = "oauth2",
                          Name = "Bearer",
                          In = ParameterLocation.Header,
                        },
                        new List<string>()
                    }
                    });
            }
            );


            builder.Services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
           .AddJwtBearer(options =>
           {
               options.RequireHttpsMetadata = false;
               options.SaveToken = true;
               options.TokenValidationParameters = new TokenValidationParameters()
               {
                   ValidateIssuer = true,
                   ValidIssuer = builder.Configuration["Tokens:Issuer"],
                   ValidateAudience = true,
                   ValidAudience = builder.Configuration["Tokens:Issuer"],
                   ValidateLifetime = true,
                   ValidateIssuerSigningKey = true,
                   ClockSkew = TimeSpan.Zero,
                   IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(builder.Configuration["Tokens:Key"]))
               };
           });

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.UseAuthentication();

            app.MapControllers();

            app.Run();
        }
    }
}