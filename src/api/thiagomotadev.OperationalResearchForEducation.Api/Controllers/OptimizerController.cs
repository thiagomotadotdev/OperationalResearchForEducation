using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using thiagomotadev.OperationalResearchForEducation.Api.CustomizedAutoMapper;
using thiagomotadev.OperationalResearchForEducation.Application.Ports;
using thiagomotadev.OperationalResearchForEducation.Application.ValueObjects;
using System.Threading.Tasks;

namespace thiagomotadev.OperationalResearchForEducation.Api.Controllers
{
    [Route("optimizer")]
    [ApiController]
    public class OptimizerController : CustomizedControllerBase<OptimizerController>
    {
        private readonly ILinearOptimizer _linearOptimizer;
        private readonly IIntegerOptimizer _integerOptimizer;

        public OptimizerController(
            ILogger<OptimizerController> logger, 
            ICustomizedMapper customizedMapper, 
            ILinearOptimizer linearOptimizer,
            IIntegerOptimizer integerOptimizer)
            : base(logger, customizedMapper)
        {
            _linearOptimizer = linearOptimizer;
            _integerOptimizer = integerOptimizer;
        }

        [HttpPost]
        [Route("linear/solve")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<OptimizationSolution>> SolveWithLinearOptimizer([FromBody] OptimizationProblem problem)
        {
            return Ok(await _linearOptimizer.Solve(problem));
        }

        [HttpPost]
        [Route("integer/solve")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<OptimizationSolution>> SolveWithIntegerOptimizer([FromBody] OptimizationProblem problem)
        {
            return Ok(await _integerOptimizer.Solve(problem));
        }

        [HttpGet]
        [Route("example")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<OptimizationProblem> GetExamples()
        {
            return Ok(OptimizationProblem.Examples);
        }

        [HttpGet]
        [Route("example/{code}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<OptimizationProblem> GetExample(int code)
        {
            return Ok(OptimizationProblem.Examples[code]);
        }
    }
}
