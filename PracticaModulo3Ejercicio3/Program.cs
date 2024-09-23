using PracticaModulo3Ejercicio3.Ejercicio3;

// Crear una instancia de la clase Alumno
Alumno alumno1 = new Alumno
{
    Nombre = "Miguel Angel",
    Matricula = "MISN-55-24",
    Carrera = "Ingeniería en Sistemas"
};

// Asignar calificaciones al alumno
alumno1.Calificaciones.Add(90);
alumno1.Calificaciones.Add(95);
alumno1.Calificaciones.Add(90);
alumno1.Calificaciones.Add(92);

// Mostrar la información del alumno
alumno1.MostrarInformacion();

// Ahora con un nuevo alumno para probar valores diferentes
Alumno alumno2 = new Alumno
{
    Nombre = "Alicia Ortega",
    Matricula = "EISN-30-24",
    Carrera = "Ingenieria en Sistemas"
};

// Asignar calificaciones al segundo alumno
alumno2.Calificaciones.Add(80);
alumno2.Calificaciones.Add(75);
alumno2.Calificaciones.Add(90);
alumno2.Calificaciones.Add(100);

// Mostrar la información del segundo alumno
alumno2.MostrarInformacion();
//añado una pausa para que se vea el resultado
Console.ReadLine();

//como no se estan capturando datos no use el try catch ya que no dara errores
