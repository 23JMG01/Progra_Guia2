Proceso CalculadoraTrigonometrica
    Definir angulo, radianes Como Real
    Definir opcion Como Entero
    
    Escribir "******** CALCULADORA FUNCIONES TRIGONOMETRICAS ********"
    Escribir "1 ? Seno"
    Escribir "2 ? Coseno"
    Escribir "3 ? Tangente"
    
    Escribir "Ingrese el ángulo en grados:"
    Leer angulo
    
    // Convertir a radianes
    radianes <- angulo * PI / 180
    
    Escribir "Seleccione una opción:"
    Leer opcion
    
    Segun opcion Hacer
        1:
            Escribir "Seno: ", sen(radianes)
        2:
            Escribir "Coseno: ", cos(radianes)
        3:
            Escribir "Tangente: ", tan(radianes)
        De Otro Modo:
            Escribir "Opción inválida"
    FinSegun
FinProceso