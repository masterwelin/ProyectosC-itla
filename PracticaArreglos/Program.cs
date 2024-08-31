using PracticaArreglos.Practicas;

string linea = string.Empty;
int opcion = 0;

Console.WriteLine("Elija cual programa quiere ejecutar:\n1)Programa Array 1\n2)Programa Array 2\n3)Programa Array 3");

linea = Console.ReadLine();

if (!int.TryParse(linea, out opcion))
{
    Console.WriteLine("La opción elegida es invalida es invalida.");
    return;
}

switch (opcion)

{
    case 1:
        ProgramaArray1 programaArray1 = new ProgramaArray1();
        programaArray1.Calcular();
        break;

    case 2:
        ProgramaArray2 programaArray2 = new ProgramaArray2();
        programaArray2.Calcular();
        break;

    case 3:
        ProgramaArray3 programaArray3 = new ProgramaArray3();
        programaArray3.Calcular();
        break;

    default:
        Console.WriteLine("Opción elegida es invalida...");
        break;
}

/*
ProgramaArray1 programaArray1 = new ProgramaArray1();
programaArray1.Calcular();
*/

/*ProgramaArray2 programaArray2 = new ProgramaArray2();
programaArray2.Calcular();*/

/*ProgramaArray3 programaArray3 = new ProgramaArray3();
programaArray3.Calcular();*/