using SOAPCalculator;

CalculatorService service = new CalculatorService();

Console.WriteLine("SOAP Calculator Service Simulation");
Console.WriteLine("----------------------------------");

Console.WriteLine($"Addition: {service.Add(10, 5)}");
Console.WriteLine($"Subtraction: {service.Subtract(10, 5)}");
Console.WriteLine($"Multiplication: {service.Multiply(10, 5)}");
Console.WriteLine($"Division: {service.Divide(10, 5)}");