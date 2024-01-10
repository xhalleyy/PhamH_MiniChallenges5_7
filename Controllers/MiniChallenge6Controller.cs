
using Microsoft.AspNetCore.Mvc;
using MiniChallenges5_7.Services.MiniChallenges;

namespace MiniChallenges5_7.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniChallenge6Controller : ControllerBase
{
    private readonly IMiniChallenge6Service _miniChallenge6Service;

    public MiniChallenge6Controller(IMiniChallenge6Service miniChallenge6Service)
    {
        _miniChallenge6Service = miniChallenge6Service;
    }

   [HttpGet]
   [Route("OddOrEven/{input}")]
   public string OddOrEven(string input)
   {
     return _miniChallenge6Service.OddOrEven(input);
   }

}
