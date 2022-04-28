using lametsy_server.Controllers;

namespace lametsy_server
{
    public interface Icalculator
    {
        public CalculatorResult Add(decimal a, decimal b);
        public CalculatorResult Substr(decimal a, decimal b);
        public CalculatorResult Mult(decimal a, decimal b);
        //public CalculatorResult Root(decimal a);
        //public CalculatorResult Sin(decimal a);
        //public CalculatorResult Cos(decimal a);
        public CalculatorResult Division(decimal a, decimal b);
        //CalculatorResult Root(decimal a);
        //public CalculatorResult Exp(decimal a, decimal b);
    }
}
