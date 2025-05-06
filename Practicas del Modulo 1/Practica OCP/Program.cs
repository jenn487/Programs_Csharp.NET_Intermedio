using Practica_OCP;

class Program
{
    static void Main(string[] args)
    {
        TaxCalculator calculator = new TaxCalculator();

        // Calcular impuestos para diferentes países
        try
        {
            decimal indiaTax = calculator.Calculate(1200000, 200000, "India");
            Console.WriteLine($"Impuesto en India: {indiaTax}");

            decimal usaTax = calculator.Calculate(100000, 20000, "USA");
            Console.WriteLine($"Impuesto en USA: {usaTax}");

            decimal ukTax = calculator.Calculate(80000, 15000, "UK");
            Console.WriteLine($"Impuesto en UK: {ukTax}");

        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.ReadKey();
    }
}