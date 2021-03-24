using AutoMapper;

namespace thiagomotadev.OperationalResearchForEducation.Api.CustomizedAutoMapper
{
    public class CustomizedMapperConfiguration
    {
        private readonly MapperConfiguration mapperConfiguration;

        public CustomizedMapperConfiguration() : base()
        {
            mapperConfiguration = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new CustomizedMappingProfile());
            });
        }

        public ICustomizedMapper CreateMapper()
        {
            return new CustomizedMapper(mapperConfiguration);
        }
    }
}
