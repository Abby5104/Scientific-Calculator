using System;

namespace ScientificCalculator
{
    public class CalculatorService
    {
        private Calculator calculator = new Calculator();
        private ScientificOperations scientific = new ScientificOperations();
        private TrigonometricOperations trigonometric = new TrigonometricOperations();

        public double BasicOperation(string operation, double x, double y)
        {
            if (operation == "+" || operation == "add") return calculator.Add(x, y);
            if (operation == "-" || operation == "subtract") return calculator.Subtract(x, y);
            if (operation == "*" || operation == "multiply") return calculator.Multiply(x, y);
            if (operation == "/" || operation == "divide") return calculator.Divide(x, y);

            if (operation != "+" || operation != "-" || operation != "*" || operation != "/")
            {
                if (operation != "add" || operation != "subtract" || operation != "multiply" || operation != "divide")
                {
                    Console.WriteLine("Invalid Operation!");
                }
            }

            return 0;
        }

        public double Scientific(string operation, double x, double y = 0)
        {
            if (operation == "sqrt") return scientific.SquareRoot(x);
            if (operation == "pow") return scientific.Power(x, y);

            return 0;
        }

        public double Trigonometric(string operation, double angle)
        {
            if (operation == "sin") return trigonometric.Sin(angle);
            if (operation == "cos") return trigonometric.Cos(angle);
            if (operation == "tan") return trigonometric.Tan(angle);
            return 0;
        }
    }
}
