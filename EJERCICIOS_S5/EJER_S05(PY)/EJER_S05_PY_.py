def ejer1():
    precio=float(input("Ingrese el precio del producto: "))
    print("\nElija su codigo de descuento:")
    opcion=int(input("1. Estudiante\n2. Empleado\n3. Cliente frecuente\nOpcion elegida: "))
    if (opcion==1):
        desc=0.10
    elif (opcion==2):
        desc=0.15
    elif (opcion==3):
        desc=0.20
    else:
        print("Codigo de descuento no valido")

    preciofin=precio-(precio*desc)

    if (precio>500):
        preciofin-=preciofin*0.05
    preciofin=round(preciofin,2)

    print("El precio final a pagar es:S/ ",preciofin)

import math
def ejer2():
    nota=int(input("Ingrese su nota[0-20]: "))
    if nota<0 or nota>20:
        print("La nota ingresada no se encuentra dentro del rango indicado")
    else:
        match nota:
            case n if n in range(0,11):
                print("\nDesaprobado")
            case n if n in range(11,14):
                print("\nRegular")
            case n if n in range(14,18):
                print("\nBueno")
            case n if n in range(18,21):
                print("\nExcelente")

        if nota>=14 and nota%2==0:
            print("\nBuen desempenio con nota par")
        if nota<11 or nota%2!=0:
            print("\nSe necesita reforzar")

        raiz=round(math.sqrt(nota),1)
        cubo=nota**3

        print("\nSu nota con raiz cuadrada: ", raiz)
        print("Nota elevada al cubo: ",cubo)

ejer2()
