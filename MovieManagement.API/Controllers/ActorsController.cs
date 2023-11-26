using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieManagement.Domain.Repository;

namespace MovieManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ActorsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var actorFromRepo = _unitOfWork.Actor.GetAll();
            return Ok(actorFromRepo);
        }

        [HttpGet("Movies")]
        public ActionResult GetWithMovies()
        {
            var actorFromRepo = _unitOfWork.Actor.GetActorsWithMovies();
            return Ok(actorFromRepo);
        }
    }
}