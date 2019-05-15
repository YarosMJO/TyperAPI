using AutoMapper;
using TyperAPI.Shared.Dtos;
using TyperAPI.DAL.Models;

namespace TyperAPI.Shared.Configs
{
    public class AutoMapperConfiguration
    {
        public MapperConfiguration Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDto>();
                cfg.CreateMap<Word, WordDto>();
                cfg.CreateMap<Score, ScoreDto>();
            });

            return config;
        }
    }
}
