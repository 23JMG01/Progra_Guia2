Algoritmo DiasDeLaSemana
	Definir opc Como Entero
	Definir num1, num2 Como Entero
	
	Escribir "*********************"
	Escribir "*  Notas *"
	Escribir "*********************"
	Escribir "1- A = Excelente"
	Escribir "2- B = Bueno"
	Escribir "3- c = Regular"
	Escribir "4- D = deficiente"
	Escribir "5- E = reprobado"
	

	
	Leer opc
	Escribir "Digite dos valores numericos"
	Leer num1
	leer num2
	
	segun opc Hacer
		1: 
			Escribir "La suma es: ", (num1+num2)
			
		2: 
			Escribir "La resta es: ", (num1-num2)
		3: 
			Escribir "La Multiplicacion es: ", (num1*num2)
		4: 
			Escribir "La Division es: ", (num1/num2)
		De Otro Modo:
			Escribir "Error al operar los numeros"
			
			
	FinSegun
FinAlgoritmo
