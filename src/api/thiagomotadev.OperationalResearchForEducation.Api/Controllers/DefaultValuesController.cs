using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using thiagomotadev.OperationalResearchForEducation.Api.CustomizedAutoMapper;
using thiagomotadev.OperationalResearchForEducation.Application.ValueObjects;

namespace thiagomotadev.OperationalResearchForEducation.Api.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("default-values")]
    public class DefaultValuesController : CustomizedControllerBase<DefaultValuesController>
    {
        public DefaultValuesController(
            ILogger<DefaultValuesController> logger,
            ICustomizedMapper customizedMapper)
            : base(logger, customizedMapper)
        { }

        [HttpGet]
        [Route("first-solution-strategy")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IList<FirstSolutionStrategy>> GetFirstSolutionStrategies()
        {
            return Ok(CustomizedEnum.GetAll<FirstSolutionStrategy>());
        }

        [HttpGet]
        [Route("linear-solve-type")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IList<LinearSolveType>> GetLinearSolveTypes()
        {
            return Ok(CustomizedEnum.GetAll<LinearSolveType>());
        }
    }
}
