using Microsoft.AspNetCore.Mvc;

namespace LinqDemo.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public void Get()
    {
        #region 延迟查询

        //     int[] nums = { 1, 3, 4, 5, 7 };
        // // var res = from u in nums where u > 4 select u;
        //  var res = (from u in nums where u > 4 select u).ToList();
        // foreach (var item in res)
        // {
        //     System.Console.WriteLine(item);
        // }
  
        // nums[0] = 6;
        // foreach (var item in res)
        // {
        //     System.Console.WriteLine(item);
        // }
        #endregion
        
        #region Linq访问泛型集合
            
        #endregion

    }
}
