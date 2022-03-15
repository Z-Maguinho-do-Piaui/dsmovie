using Backend.Data;
using Backend.Domain.Entities.Movie;
using Backend.Domain.Entities.Score;
using Backend.Domain.Entities.User;
using Backend.Repository;
using Backend.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Backend.Ioc
{
    public static class NativeInjectorBootStrapp
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            // Services 
            services.AddScoped<IMovieService, MovieServices>();
            //services.AddScoped<IUserService, UserService>();
            services.AddScoped<IScoreService, ScoreService>();

            // Repositoty 
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IScoreRepository, ScoreRepository>();

        }
    }
}
