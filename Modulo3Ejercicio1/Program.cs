using Modulo3Ejercicio1;


Punto punto1 = new Punto();

// Cargar valores de X e Y
punto1.CargarValores(4, 5);
punto1.ImprimirCuadrante();  

Punto punto2 = new Punto();
punto2.CargarValores(-3, 6);
punto2.ImprimirCuadrante();  

Punto punto3 = new Punto();
punto3.CargarValores(0, -7);
punto3.ImprimirCuadrante();  

Console.ReadLine();