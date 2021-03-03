using BlogApp.Business.Concrete;
using BlogApp.Business.Interface;
using BlogApp.Business.Tools.FacadeTool;
using BlogApp.Business.Tools.JWTTool;
using BlogApp.Business.Tools.LogTool;
using BlogApp.Business.ValidationRules.FluentValidation;
using BlogApp.DataAccess.Concrete.EFCore.Context;
using BlogApp.DataAccess.Concrete.EFCore.Repositories;
using BlogApp.DataAccess.Interface;
using BlogApp.DTO.DTOs.AppUserDtos;
using BlogApp.DTO.DTOs.CategoryBlogDtos;
using BlogApp.DTO.DTOs.CategoryDtos;
using BlogApp.DTO.DTOs.CommentDtos;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace BlogApp.Business.Containers.MicrosoftIoC
{
    public static class CustomIoCExtension 
    {
        public static void AddDependencies(this IServiceCollection services)
        {

            services.AddDbContext<BlogAppContext>();

            services.AddScoped(typeof(IGenericDal<>),typeof(EFGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>),typeof(GenericManager<>));

            services.AddScoped<IBlogService,BlogManager>();
            services.AddScoped<IBlogDal,EFBlogRepository>();

            services.AddScoped<ICategoryService,CategoryManager>();
            services.AddScoped<ICategoryDal,EFCategoryRepository>();

            services.AddScoped<IAppUserService,AppUserManager>();
            services.AddScoped<IAppUserDal,EFAppUserRepository>();

            services.AddScoped<ICommentService,CommentManager>();
            services.AddScoped<ICommentDal,EFCommentRepository>();

            services.AddScoped<IJwtService,JwtManager>();

            services.AddScoped<ICustomLogger, NLogAdapter>();

            services.AddScoped<IFacade,Facade>();

            services.AddTransient<IValidator<AppUserLoginDto>,AppUserLoginValidator>();
            services.AddTransient<IValidator<CategoryAddDto>,CategoryAddValidator>();
            services.AddTransient<IValidator<CategoryBlogDto>,CategoryBlogValidator>();
            services.AddTransient<IValidator<CategoryUpdateDto>,CategoryUpdateValidator>();
            services.AddTransient<IValidator<CommentAddDto>,CommentAddValidator>();
            
            
        }
    }
}