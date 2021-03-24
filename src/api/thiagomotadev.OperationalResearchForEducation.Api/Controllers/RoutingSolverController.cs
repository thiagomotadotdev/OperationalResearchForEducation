using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using thiagomotadev.OperationalResearchForEducation.Api.CustomizedAutoMapper;
using thiagomotadev.OperationalResearchForEducation.Application.Ports;
using thiagomotadev.OperationalResearchForEducation.Application.ValueObjects;

namespace thiagomotadev.OperationalResearchForEducation.Api.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("routing-solvers")]
    public class RoutingSolverController : CustomizedControllerBase<RoutingSolverController>
    {
        private readonly IRoutingXToYSolver _routingXToYSolver;
        private readonly ITravelingSalesmanSolver _travelingSalesmanSolver;

        public RoutingSolverController(
            ILogger<RoutingSolverController> logger, 
            ICustomizedMapper customizedMapper,
            IRoutingXToYSolver routingXToYSolver,
            ITravelingSalesmanSolver travelingSalesmanSolver)
            : base(logger, customizedMapper)
        {
            _routingXToYSolver = routingXToYSolver;
            _travelingSalesmanSolver = travelingSalesmanSolver;
        }

        [HttpPost]
        [Route("traveling-salesman-solver")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<RoutingProblemSolution> TravelingSalesmanSolver([FromBody] RoutingProblem problem)
        {
            return Ok(_travelingSalesmanSolver.Solve(problem));
        }

        [HttpPost]
        [Route("routing-x-to-y-solver")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<RoutingProblemSolution> RoutingXToYSolver([FromBody] RoutingProblem problem)
        {
            return Ok(_routingXToYSolver.Solve(problem));
        }

        [HttpGet]
        [Route("first-solution-strategy")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IList<FirstSolutionStrategy>> GetFirstSolutionStrategies()
        {
            return Ok(CustomizedEnum.GetAll<FirstSolutionStrategy>());
        }
    }
}
