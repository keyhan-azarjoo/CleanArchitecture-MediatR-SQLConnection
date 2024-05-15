using Core.Interfaces.Repository;
using Core.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase // BaseController
    {

        public IMediator _mediatr { get; }
        public PostController(IMediator mediatR)
        {
            _mediatr = mediatR;
        }


        [HttpGet(Name = "GetLatestPost")]
        public async Task<IActionResult> GetLatestPost(GetLatestPostQuery query)
        {
            var result = await _mediatr.Send(query);
            return Ok(true);
        }


    }





}






