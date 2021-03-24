using AutoMapper;

namespace thiagomotadev.OperationalResearchForEducation.Api.CustomizedAutoMapper
{
    public class CustomizedMapper : Mapper, ICustomizedMapper
    {
        public CustomizedMapper(IConfigurationProvider configurationProvider) : base(configurationProvider) { 
        }
    }
}
