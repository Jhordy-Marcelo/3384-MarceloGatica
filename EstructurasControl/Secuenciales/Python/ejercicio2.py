print("=== Cálculo de Promedio Ponderado ===")

nota1 = float(input("Ingresa la primera nota (30%): "))
nota2 = float(input("Ingresa la segunda nota (30%): "))
nota3 = float(input("Ingresa la tercera nota (40%): "))

promedio = (nota1 * 0.3) + (nota2 * 0.3) + (nota3 * 0.4)

print(f"\nEl promedio ponderado es: {promedio:.2f}")
