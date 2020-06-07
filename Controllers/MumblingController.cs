using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MumblingController : ControllerBase
    {
        [HttpGet("{mumbling}")]
        public string Mumble(string mumbling)
        {
            var answer = "";

            for (var indexOfLetter = 0; indexOfLetter < mumbling.Length; indexOfLetter++)
            {
                var upperCase = mumbling.ToUpper();
                var currentLetter = upperCase[indexOfLetter];
                if (indexOfLetter != 0)
                {
                    answer += "-";
                    answer += currentLetter;
                    answer += new string(char.ToLower(currentLetter), indexOfLetter);
                }
                else
                {
                    answer += currentLetter;
                }
            }
            return answer;
        }
    }
}