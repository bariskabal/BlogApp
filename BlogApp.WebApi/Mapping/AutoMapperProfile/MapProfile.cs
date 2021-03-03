using AutoMapper;
using BlogApp.DTO.DTOs.BlogDtos;
using BlogApp.DTO.DTOs.CategoryDtos;
using BlogApp.DTO.DTOs.CommentDtos;
using BlogApp.Entity.Concrete;
using BlogApp.WebApi.Models;

namespace BlogApp.WebApi.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<BlogListDto,Blog>();
            CreateMap<Blog,BlogListDto>();
            CreateMap<BlogUpdateModel,Blog>();
            CreateMap<Blog,BlogUpdateModel>();
            CreateMap<BlogAddModel,Blog>();
            CreateMap<Blog,BlogAddModel>();

            CreateMap<CategoryListDto,Category>();
            CreateMap<Category,CategoryListDto>();
            CreateMap<CategoryAddDto,Category>();
            CreateMap<Category,CategoryAddDto>();
            CreateMap<CategoryUpdateDto,Category>();
            CreateMap<Category,CategoryUpdateDto>();

            CreateMap<Comment,CommentListDto>();
            CreateMap<CommentListDto,Comment>();
            CreateMap<Comment,CommentAddDto>();
            CreateMap<CommentAddDto,Comment>();

        }
    }
}