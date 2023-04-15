void arreglos()
{
    Console.Write("¿Cuántos alumnos tiene la clase?: ");
    int numAlumnos = int.Parse(Console.ReadLine());

    string[] nombres = new string[numAlumnos];
    int[] notas = new int[numAlumnos];

    for (int i = 0; i < numAlumnos; i++)
    {
        Console.Write($"\nNombre del alumno {i + 1}: ");
        nombres[i] = Console.ReadLine();

        Console.Write($"Nota del alumno {i + 1}: ");
        notas[i] = int.Parse(Console.ReadLine());
    }

    int notaMasAlta = notas[0];
    string nombreNotaMasAlta = nombres[0];

    foreach (int nota in notas)
    {
        if (nota > notaMasAlta)
        {
            notaMasAlta = nota;
        }
    }

    foreach (string nombre in nombres)
    {
        if (notas[Array.IndexOf(nombres, nombre)] == notaMasAlta)
        {
            nombreNotaMasAlta = nombre;
            break;
        }
    }

    int notaMasBaja = notas[0];
    string nombreNotaMasBaja = nombres[0];

    foreach (int nota in notas)
    {
        if (nota < notaMasBaja)
        {
            notaMasBaja = nota;
        }
    }

    foreach (string nombre in nombres)
    {
        if (notas[Array.IndexOf(nombres, nombre)] == notaMasBaja)
        {
            nombreNotaMasBaja = nombre;
            break;
        }
    }

    Console.WriteLine($"La nota más alta es {notaMasAlta} y es del alumno {nombreNotaMasAlta}");
    Console.WriteLine($"La nota más baja es {notaMasBaja} y es del alumno {nombreNotaMasBaja}");
}

arreglos();

