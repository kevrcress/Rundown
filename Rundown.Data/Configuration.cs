using AutoMapper;

namespace Rundown.Data
{
    public static class Configuration
    {
        public static void InitializeAutoMapper()
        {
            Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<Data.Issues, Models.Issue>();
                    cfg.CreateMap<Rundown.Models.Issue, Data.Issues>()
                        .ForMember(dest => dest.StatusId, opts => opts.MapFrom(src => src.Status)); ;
                });
        }
    }
}