using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Server;

[ApiController]
[Route("v{version:apiVersion}/game-configs")]
[ApiVersion("1")]
public class GameConfigsController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult> Get(CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        return Ok("1");
    }
}
