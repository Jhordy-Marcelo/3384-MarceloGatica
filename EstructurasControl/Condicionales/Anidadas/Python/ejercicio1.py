print("=== Verificación de número ===")

numero = int(input("Ingresa un número: "))

# Condicional anidada
if numero >= 0:
    if numero == 0:
        print("El número es cero.")
    else:
        print("El número es positivo.")
else:
    print("El número es negativo.")
