
using Microsoft.AspNetCore.Mvc;
using MiniChallenges5_7.Services.MiniChallenges;


namespace MiniChallenges5_7.Controllers;

[ApiController]
[Route("[controller]")]
public class AlphanumericReverseItController : ControllerBase
{
    private readonly IAlphaNumericReverseItService _alphaNumericReverseItService;

    public AlphanumericReverseItController(IAlphaNumericReverseItService alphaNumericReverseItService)
    {
        _alphaNumericReverseItService = alphaNumericReverseItService;
    }

    [HttpGet]
    [Route("ReverseInput/{input}")]
    public string ReverseInput(string input)
    {
        return _alphaNumericReverseItService.ReverseInput(input);
    }
}
