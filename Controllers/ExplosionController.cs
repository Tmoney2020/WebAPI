using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExplosionController : ControllerBase
    {
        [HttpGet("{explosion}")]
        public string Explosions(string explosion)
        {
            var answer = "";

            for (var index = 0; index < explosion.Length; index++)
            {
                var currentCharacter = explosion[index];
                var repeatCount = int.Parse($"{currentCharacter}");

                for (var repeatIndex = 0; repeatIndex < repeatCount; repeatIndex++)
                {
                    answer += currentCharacter;
                }
            }
            return answer;
        }
    }
}