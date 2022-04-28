using Microsoft.AspNetCore.Mvc;

namespace lametsy_server.Controllers;

[ApiController]
[Route("api")]

public class Controler_calculator : ControllerBase
{


    private readonly Icalculator _calculator;

    public Controler_calculator(Icalculator calculator)
    {
        _calculator = calculator;
    }



    [HttpGet("calculator")]
    public IActionResult GetAddOperation(string opp, decimal a, decimal b)
    {
        CalculatorResult result = new CalculatorResult();

        switch (opp)
        {
            case "add":
                {
                    result = _calculator.Add(a,b);
                    break;
                }
            case "substr":
                {
                    result = _calculator.Substr(a, b);
                    break;
                }
            case "mult":
                {
                    result = _calculator.Mult(a, b);
                    break;

                }
            case "div":
                {
                    result = _calculator.Division(a, b);
                    break;

                }
            //case "exp":
            //    {
            //        result = _calculator.Exp(a, b);//Math.Pow((double)a, (double)b);
            //        break;

            //    }


            default:
                return BadRequest("input malformed");
        }
        return Ok(result);
    }


//    [HttpGet("calculatorgh")]

//    public IActionResult GetAddOperation(string opp, decimal a)
//    {
//        decimal result = 0;
//        switch (opp)
//        {
//            case "cos":
//                {
//                    result = Math.Cos(a);
//                    break;
//                }
//            case "sin":
//                {
//                    result = Math.Sin(a);
//                    break;
//                }  
//            case "root":
//                {
//                    result = Math.Sqrt(a);
//                    break;
//                }


//            default:
//                return BadRequest("input malformed");
//        }
//        return Ok(new CalculatorResult
//        {
//            OperationResult = result
//        });
//    }

}
public class CalculatorResult
{
    public decimal? OperationResult { get; internal set; }
    public string? Error {get; internal set; }
}