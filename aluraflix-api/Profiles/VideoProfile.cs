using System;
using aluraflix_api.Data.Dtos;
using aluraflix_api.Models;
using AutoMapper;

namespace aluraflix_api.Profiles
{
    public class VideoProfile : Profile
    {
        public VideoProfile()
        {
            CreateMap<CreateVideoDto, Video>();
            CreateMap<Video, ReadVideoDto>();
            CreateMap<UpdateVideoDto, Video>();
        }

    }
}
