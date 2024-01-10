
using Microsoft.AspNetCore.Mvc;
using MiniChallenges5_7.Services.MiniChallenges;

namespace MiniChallenges5_7.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniChallenge5Controller : ControllerBase
{
    private readonly IMiniChallenge5Service _miniChallenge5Service;

    public MiniChallenge5Controller(IMiniChallenge5Service miniChallenge5Service)
    {
        _miniChallenge5Service = miniChallenge5Service;
    }

    [HttpGet]
    [Route("MadLib/{creature}/{name1}/{name2}/{place}/{item}/{noun}/{adjective}/{adverb}/{presentVerb1}/{presentVerb2}/{pastVerb1}")]
    public string MadLib(string creature, string name1, string name2, string place, string item, string noun, string adjective, string adverb, string presentVerb1, string presentVerb2, string pastVerb1)
    {
        return _miniChallenge5Service.MadLib(creature, name1, name2, place, item, noun, adjective, adverb, presentVerb1, presentVerb2, pastVerb1);

    }
}
