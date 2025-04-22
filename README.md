# Antenna Distance Calculator
![image](https://github.com/user-attachments/assets/7d47a81f-3a71-4276-8665-f7b756896c75)

A C# console application that calculates the maximum theoretical distance between two antennas using the Friis transmission equation.

## Features

- Calculates maximum communication distance between antennas
- Implements the Friis transmission equation
- Simple console interface
- Supports dBm, dBi units for power and gain calculations
- Outputs distance in kilometers

## Friis Transmission Equation

The application uses the logarithmic form of the Friis equation:

```
Pr = Pt + Gt + Gr - 20·log₁₀(f) - 20·log₁₀(d) - 32.44
```

Rearranged to solve for distance (d):
```
d = 10^[(Pt + Gt + Gr - Pr - 20·log₁₀(f) - 32.44)/20]
```

Where:
- Pt = Transmit Power (dBm)
- Gt = Transmit Antenna Gain (dBi)
- Gr = Receive Antenna Gain (dBi)
- Pr = Receive Sensitivity (dBm)
- f = Frequency (MHz)
- d = Distance (km)

## Requirements

- .NET 6.0 or later runtime
- Windows/macOS/Linux (any platform supporting .NET)

## Installation

1. Clone the repository:
```bash
git clone https://github.com/unreliablecode/Antenna-Distance-Calculator.git
```

2. Navigate to the project directory:
```bash
cd Antenna-Distance-Calculator
```

3. Run the application:
```bash
dotnet run
```

## Usage

1. Launch the application
2. Enter the required parameters when prompted:
   - Transmit Power (dBm)
   - Transmit Antenna Gain (dBi)
   - Receive Antenna Gain (dBi)
   - Receive Sensitivity (dBm)
   - Frequency (MHz)
3. View the calculated maximum distance

Example input/output:
```
=== Antenna Distance Calculator ===
Transmit Power (dBm): 20
Transmit Antenna Gain (dBi): 5
Receive Antenna Gain (dBi): 3
Receive Sensitivity / Required Power (dBm): -80
Frequency (MHz): 2400

Maximum Theoretical Distance: 2.81 km
```

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any improvements.

## License

MIT License - see [LICENSE](LICENSE) file for details
