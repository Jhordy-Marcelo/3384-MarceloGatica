print("=== Verificación de voto ===")

edad = int(input("Ingresa tu edad: "))

# Condicional anidada
if edad >= 0:
    if edad >= 18:
        print("Puedes votar, eres mayor de edad.")
    else:
        print("No puedes votar, eres menor de edad.")
else:
    print("La edad ingresada no es válida.")
