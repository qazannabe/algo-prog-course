double celsius = 19.3;

const double FahrenheitScale = 9.0 / 5.0;
const double FahrenheitOffset = 32.0; 
const double KelvinOffset = 273.15;

double fahrenheit = celsius * FahrenheitScale + FahrenheitOffset;

double kelvin = celsius + KelvinOffset;

Console.WriteLine($"{celsius}°C = {fahrenheit}°F = {kelvin}K");