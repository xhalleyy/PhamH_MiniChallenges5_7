
using Microsoft.AspNetCore.Mvc;
using MiniChallenges5_7.Services.MiniChallenges;


namespace MiniChallenges5_7.Controllers;

[ApiController]
[Route("[controller]")]
public class NumericReverseItController : ControllerBase
{
    private readonly INumericReverseItService _numericReverseItService;

    public NumericReverseItController(INumericReverseItService numericReverseItService)
    {
        _numericReverseItService = numericReverseItService;
    }

    [HttpGet]
    [Route("ReverseInput/{input}")]
    public string ReverseInput(string input)
    {
        return _numericReverseItService.ReverseInput(input);
    }
}
