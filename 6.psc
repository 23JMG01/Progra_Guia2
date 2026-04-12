Proceso TipoCaracter
    Definir c Como Caracter
    
    Escribir "Ingrese un carácter:"
    Leer c
    
    Si (c >= "0" Y c <= "9") Entonces
        Escribir "Es un dígito"
    Sino
        Segun Mayusculas(c) Hacer
            "A","E","I","O","U":
                Escribir "Es una vocal"
            De Otro Modo:
                Escribir "No es vocal ni dígito"
        FinSegun
    FinSi
FinProceso