import sys
import Python.Basicos.fibonacci as fibonacci
import multiplos
import passwords


while(True):
    print("Ingresa el número del ejercicio que quieres ejecutar")
    print("1: Secuencia de fibonacci")
    print("2: Múltiplos de 3 y 5")
    print("3: Generador de passwords")
    print("4: Salir")
    seleccion = input("Selecciona el ejercicio: ")

    if(seleccion == "1"):
        limite = input("Ingresa el número límite de la secuencia: ")
        fibonacci.fib(int(limite))
    elif (seleccion == "2"):
        print("Ejercicio de múltiplos de 3 y 5")
        multiplos.GetMultiples()
    elif (seleccion == "3"):
        print("Generador automático de passwords")
        passwords.GeneratePassword()
    elif (seleccion == "4"):
        sys.exit()
    
