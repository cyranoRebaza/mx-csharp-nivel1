# codigo se ve distinto

## codigo version .net 5

El codigo hasta la version 5 era completa

```bash
using System;

namespace U01_T08_HolaMundoCompleto
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hola, mundo!!!");
        }
    }

}

```

# codigo- distinto

Cuando creamos un proyecto de consola aparece sin

- using system;
- El bloque de namespace sin {} con namespace nombre_programa;

```bash
dotnet new console -o nombre-programa --use-program-main

```

```bash

namespace U01_T08_HolaMundoCompleto;

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hola, mundo!!!");
        }
    }


```

# codigo - moderno .net version 8 o 9

Cuando creamos un proyecto de consola aparece sin nada, solo

```bash
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

```

```bash

namespace U01_T08_HolaMundoCompleto;

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hola, mundo!!!");
        }
    }


```
