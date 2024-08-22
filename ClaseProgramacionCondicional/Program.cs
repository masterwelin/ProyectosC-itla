// See https://aka.ms/new-console-template for more information


using ClaseProgramacionCondicional;

//Ejercicio 2
Console.WriteLine(" 1) Diseñar un programa que solicite al usuario dos números y, \n si el primer número es más grande, calcule y muestre su suma y resta. De lo contrario, \n calculará y mostrará su producto y cociente.\n");
Ejercicio1CalculoDosNumeros Ejercicio1CalculoDosNumeros = new Ejercicio1CalculoDosNumeros();
Ejercicio1CalculoDosNumeros.Calcular();

//Ejercicio 2
Console.WriteLine(" 2) Leer tres calificaciones y calcular el promedio. \n Si el promedio es igual o superior a siete, imprimir un mensaje indicando que el alumno ha aprobado.\n");
Ejercicio2LeerTresCalificaciones Ejercicio2LeerTresCalificaciones = new Ejercicio2LeerTresCalificaciones();
Ejercicio2LeerTresCalificaciones.Calcular();

//Ejercicio 3
Console.WriteLine(" 3) Desarrollar un programa que calcule el nivel de un postulante a partir de los resultados de un test. \n El programa recibirá como entrada el número total de preguntas y las respuestas correctas, \n y devolverá un nivel según el porcentaje de aciertos.\n");
Ejercicio3NivelPostulante Ejercicio3NivelPostulante = new Ejercicio3NivelPostulante();
Ejercicio3NivelPostulante.Calcular();


