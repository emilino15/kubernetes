try:
    n = 10
    print("El número seleccionado fue: ", n)

    for x in range(n):
        print(x)

except ValueError:
    print("Error: No se puede convertir el parámetro proporcionado a entero")
