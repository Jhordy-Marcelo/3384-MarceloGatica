print("=== Conversión de Temperatura ===")

celsius = float(input("Ingresa la temperatura en grados Celsius: "))

fahrenheit = (celsius * 9/5) + 32
kelvin = celsius + 273.15

print(f"\nTemperatura en Fahrenheit: {fahrenheit:.2f} °F")
print(f"Temperatura en Kelvin: {kelvin:.2f} K")
