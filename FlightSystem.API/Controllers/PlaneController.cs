using FlightSystem.API.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace FlightSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaneController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<PlaneController> _logger;
        public PlaneController(IUnitOfWork unitOfWork, ILogger<PlaneController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPlanes()
        {
            try
            {
                var planes = await _unitOfWork.PlaneInfos.GetAll();
                return Ok(planes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Có lỗi trong {nameof(GetPlanes)}");
                return StatusCode(500, "Vui lòng thử lại sau");
            }
        }
    }
}
