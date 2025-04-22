using System;

class AntennaDistanceCalculator
{
    static void Main()
    {
        Console.WriteLine("=== Antenna Distance Calculator ===");
        
        try
        {
            // Input values
            Console.Write("Transmit Power (dBm): ");
            double Pt = double.Parse(Console.ReadLine());

            Console.Write("Transmit Antenna Gain (dBi): ");
            double Gt = double.Parse(Console.ReadLine());

            Console.Write("Receive Antenna Gain (dBi): ");
            double Gr = double.Parse(Console.ReadLine());

            Console.Write("Receive Sensitivity / Required Power (dBm): ");
            double Pr = double.Parse(Console.ReadLine());

            Console.Write("Frequency (MHz): ");
            double freqMHz = double.Parse(Console.ReadLine());

            // Friis Transmission Equation (rearranged for distance)
            double exponent = (Pt + Gt + Gr - Pr - 20 * Math.Log10(freqMHz) - 32.44) / 20;
            double distanceKm = Math.Pow(10, exponent);

            Console.WriteLine($"\nMaximum Theoretical Distance: {distanceKm:F2} km");
            Console.WriteLine($"Frequency: {freqMHz} MHz");
            Console.WriteLine($"Path Loss: {Pt + Gt + Gr - Pr:F2} dB");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter numeric values.");
        }
    }
}
