using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("/SecurityIssueOnUseRandom")]
        public IEnumerable<SampleModel> GetSecurityIssueOnUseRandom()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new SampleModel
            {
                Date = DateTime.Now.AddDays(index),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("/BugOnNullPath")]
        public SampleModel GetBugOnNullPath()
        {
			SampleModel sampleModel = new()
			{
				Date = DateTime.Now
			};
			return sampleModel;
        }

        [HttpGet("/BugOnAlwaysEvaluateToFalse")]
        public IActionResult GetBugOnAlwaysEvaluateToFalse()
        {
            return Ok();
        }
    }
}
