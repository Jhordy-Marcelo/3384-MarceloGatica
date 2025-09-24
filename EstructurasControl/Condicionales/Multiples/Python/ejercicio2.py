print("=== Menú de Opciones ===")
print("1. Sumar")
print("2. Restar")
print("3. Multiplicar")
print("4. Dividir")

opcion = int(input("Elige una opción (1-4): "))

# Condicional múltiple
if opcion == 1:
    print("Elegiste: Sumar")
elif opcion == 2:
    print("Elegiste: Restar")
elif opcion == 3:
    print("Elegiste: Multiplicar")
elif opcion == 4:
    print("Elegiste: Dividir")
else:
    print("Opción inválida")
