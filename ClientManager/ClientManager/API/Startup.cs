using API.Models;
using API.Models.Base;
using AutoMapper;
using Domain.Entities;
using Domain.Entities.Base;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Repository.Base;
using Domain.Interfaces.Service;
using Domain.Interfaces.Service.Base;
using Domain.Interfaces.UnitOfWork;
using Domain.Services;
using Domain.Services.Base;
using Infra.Context;
using Infra.Repository;
using Infra.Repository.Base;
using Infra.UnitOfWork;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: "All",
                                  builder =>
                                  {
                                      builder.WithOrigins("*");
                                  });
            });

            services.AddSwaggerGen(c =>
            {

                c.SwaggerDoc("v1",
                    new OpenApiInfo()
                    {
                        Title = "Client Manager - D'Artagnan Lamarca",
                        Version = "v1",
                        Description = "Client Manager - D'Artagnan Lamarca",
                        Contact = new OpenApiContact
                        {
                            Name = "D'Artagnan Lamarca",
                            Url = new Uri("https://github.com/skaiwolker")
                        }
                    });

                c.IncludeXmlComments("ClientManager.Api.xml");
            });

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteService, ClienteService>();

            services.AddScoped<ILogradouroRepository, LogradouroRepository>();
            services.AddScoped<ILogradouroService, LogradouroService>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IRepository<BaseEntity>, Repository<BaseEntity>>();
            services.AddScoped<IService<BaseEntity>, Service<BaseEntity>>();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ClienteResponseModel, Cliente>();
                cfg.CreateMap<Cliente, ClienteResponseModel>();

                cfg.CreateMap<LogradouroResponseModel, Logradouro>();
                cfg.CreateMap<Logradouro, LogradouroResponseModel>();

                cfg.CreateMap<UserResponseModel, User>();
                cfg.CreateMap<User, UserResponseModel>();

                cfg.CreateMap<BaseResponseModel, BaseEntity>();
                cfg.CreateMap<BaseEntity, BaseResponseModel>();

                cfg.CreateMap<ClienteRequestModel, Cliente>();
                cfg.CreateMap<Cliente, ClienteRequestModel>();

                cfg.CreateMap<LogradouroRequestModel, Logradouro>();
                cfg.CreateMap<Logradouro, LogradouroRequestModel>();

                cfg.CreateMap<UserRequestModel, User>();
                cfg.CreateMap<User, UserRequestModel>();

                cfg.CreateMap<BaseRequestModel, BaseEntity>();
                cfg.CreateMap<BaseEntity, BaseRequestModel>();
            });

            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            services.AddDbContext<ClientManagerContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("All");

            app.UseSwagger();

            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Client Manager - D'Artagnan Lamarca");
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
