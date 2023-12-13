using Microsoft.AspNetCore.Mvc;

namespace testWebApi.Controllers;

[ApiController]
[Route("breeds")]
public class MockDogApiController : ControllerBase
{
    private readonly BreedService _breedService;

    public MockDogApiController()
    {
        _breedService = new BreedService();
    }

    [HttpGet]
    public IActionResult GetBreeds()
    {
        var breeds = _breedService.GetBreeds();
        return Ok(breeds);
    }
}
