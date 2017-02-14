namespace Sample.Logic.Configuration
{
    using AutoMapper;
    using Database.Models;
    using TransferModels;
    public class AutoMapperConfig
    {
        public static MapperConfiguration ConfigureMappings()
        {
            var configuration = new MapperConfiguration(x =>
            {
                x.CreateMap<ExampleFirst, ExampleFirstDto>().ReverseMap();
            });

            return configuration;
        }
    }
}
