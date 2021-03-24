using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using thiagomotadev.OperationalResearchForEducation.Api.CustomizedAutoMapper;

namespace thiagomotadev.OperationalResearchForEducation.Api.Controllers
{
    public class CustomizedControllerBase<T> : ControllerBase
    {
        protected readonly ILogger<T> _logger;
        protected readonly ICustomizedMapper _customizedMapper;

        public CustomizedControllerBase(ILogger<T> logger, ICustomizedMapper customizedMapper)
        {
            _logger = logger;
            _customizedMapper = customizedMapper;
        }
    }
}
