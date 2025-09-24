print("=== Clasificación de notas ===")

nota = int(input("Ingresa tu nota (0 - 20): "))

# Condicional múltiple
if nota >= 18:
    print("Excelente")
elif nota >= 14:
    print("Bueno")
elif nota >= 11:
    print("Regular")
else:
    print("Deficiente")
