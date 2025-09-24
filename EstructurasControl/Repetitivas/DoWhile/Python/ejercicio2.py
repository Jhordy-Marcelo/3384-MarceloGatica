print("=== Menú Principal ===")

while True:
    print("\n1. Saludar")
    print("2. Despedirse")
    print("3. Salir")
    
    opcion = int(input("Elige una opción: "))

    if opcion == 1:
        print("¡Hola! 👋")
    elif opcion == 2:
        print("¡Adiós! 👋")
    elif opcion == 3:
        print("Programa finalizado.")
        break  # condición de salida
    else:
        print("Opción no válida, intenta de nuevo.")
