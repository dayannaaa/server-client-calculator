using lametsy_server.Controllers;

namespace lametsy_server;



public class Calculator : Icalculator
{
    public CalculatorResult Add(decimal a, decimal b)
    {
        try
        {
            return new CalculatorResult
            {
                OperationResult = a + b
            };
        }
        catch (Exception ex)
        {
            return new CalculatorResult
            {
                Error = ex.Message
            };
        }
    }

    /
    public CalculatorResult Division(decimal a, decimal b)
    {
            try
            {
                return new CalculatorResult
                {
                    OperationResult = a / b
                };
            }
            catch (Exception ex)
            {
                return new CalculatorResult
                {
                    Error = ex.Message
                };
            }
        
    }

    

    CalculatorResult Icalculator.Mult(decimal a, decimal b)
    {
        
            try
            {
                return new CalculatorResult
                {
                    OperationResult = a *b
                };
            }
            catch (Exception ex)
            {
                return new CalculatorResult
                {
                    Error = ex.Message
                };
            }
        
    }


    CalculatorResult Icalculator.Substr(decimal a, decimal b)
    {
        
            try
            {
                return new CalculatorResult
                {
                    OperationResult = a - b
                };
            }
            catch (Exception ex)
            {
                return new CalculatorResult
                {
                    Error = ex.Message
                };
            }
        
    }
}
