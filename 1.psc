Proceso Operaciones
    Definir num1, num2, opcion Como Real
    
    Escribir "Ingrese primer número:"
    Leer num1
    Escribir "Ingrese segundo número:"
    Leer num2
    
    Escribir "Seleccione opción:"
    Escribir "1 ? Sumar"
    Escribir "2 ? Restar"
    Escribir "3 ? Multiplicar"
    Escribir "4 ? Dividir"
    Leer opcion
    
    Segun opcion Hacer
        1:
            Escribir "Resultado: ", num1 + num2
        2:
            Escribir "Resultado: ", num1 - num2
        3:
            Escribir "Resultado: ", num1 * num2
        4:
            Si num2 <> 0 Entonces
                Escribir "Resultado: ", num1 / num2
            Sino
                Escribir "Error: División por cero"
            FinSi
        De Otro Modo:
            Escribir "Opción inválida"
    FinSegun
FinProceso
