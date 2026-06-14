using Microsoft.AspNetCore.Mvc;
using UnitConversionAPI.Services;

namespace UnitConversionAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConversionController : ControllerBase
    {
        private readonly ConversionService _conversionService;

        // Dependency Injection Constructor
        public ConversionController(ConversionService conversionService)
        {
            _conversionService = conversionService;
        }

        // Length API
        [HttpGet("length")]
        public IActionResult ConvertLength(string from, string to, double value)
        {
            try
            {
                double result = _conversionService.ConvertLength(from, to, value);

                return Ok(new
                {
                    From = from,
                    To = to,
                    OriginalValue = value,
                    Result = result
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Temperature API
        [HttpGet("temperature")]
        public IActionResult ConvertTemperature(string from, string to, double value)
        {
            try
            {
                double result = _conversionService.ConvertTemperature(from, to, value);

                return Ok(new
                {
                    From = from,
                    To = to,
                    OriginalValue = value,
                    Result = result
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // Weight API
        [HttpGet("weight")]
        public IActionResult ConvertWeight(string from, string to, double value)
        {
            try
            {
                double result = _conversionService.ConvertWeight(from, to, value);

                return Ok(new
                {
                    From = from,
                    To = to,
                    OriginalValue = value,
                    Result = result
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}