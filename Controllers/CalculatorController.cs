using Microsoft.AspNetCore.Mvc;

namespace calculator.Controllers
{
    public class CalculatorController : BaseApiController
    {
        [HttpGet("add/{x}/{y}")]
        public double Add(double x, double y)
        {
            return x + y;
        }

        [HttpGet("sub/{x}/{y}")]
        public double Subtract(double x, double y)
        {
            return x - y;
        }

        [HttpGet("div/{x}/{y}")]
        public double Divide(double x, double y)
        {
            return x / y;
        }

        [HttpGet("multiply/{x}/{y}")]
        public double Multiply(double x, double y)
        {
            return x * y;
        }

        [HttpGet("percent/{x}/{y}/{symbol}")]
        public double Percent(double x, double y, char symbol)
        {
            if (symbol != 'n')
            {
            double result = (x / 100) * y;
                switch (symbol)
                {
                    case '+':
                        return x + result;
                        break;
                    case '-':
                        return x - result;
                        break;
                    default:
                        return result;
                        break;
                }
            }

            return x  / 100;
        }
    }

}