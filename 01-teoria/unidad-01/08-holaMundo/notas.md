# Crear proyectos de consola

1. .NET MODERNO
   - significa escribir codigo directamente en el archivo,
     sin Main, sin Class Program
   - El compilador crea por detras el Main, Program, los using
     y parte del namespace

```bash
Console.WriteLine("Hola Mundo");

```

Ya no se genera:

```bash
class Program
{
    static void Main(string[] args)
    {
    }
}

```

Namespace file-scoped

    - No lleva llaves {}

```bash
namespace MiProyecto;

Console.WriteLine("Hola mundo");

```

2. ESTILO CLASICO

```bash
using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");
        }
    }
}

```

---

## flags para el estilo clasico

- Antes (SDK viejos / transición)

```bash
dotnet new console -n U01_T08_HolaMundoCompleto  --use-program-main

```

## template clasico

- agregar: using system;
- llaves al namespace {}

```bash
using System;

namespace U01_T08_HolaMundoCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");
        }
    }
}


```

## Ejecutar el proyecto

- para ejercutar el proyecto debemos estar el la carpeta donde esta el archivo .csproj
  porque para ejecutar hay que estar parado en la carpeta donde esta ese archivo

## Forma para ver si el proyecto esta dentro de la sln

- Estar parado en la raíz de la solución (donde está el .sln) y ejecutá:

```bash
dotnet sln list

```

## resumen

- crear la carpeta raiz
- crear la solucion
- crear el proyecto de consolona usar -n nombreProyecto
  -si queremos crear el proyecto dentro de una carpeta especifica
  usar ademas de -n el -o carpetaEspecifica/nombreProyecto
- lo olvidar agregar el proyecto a la sln (revisar SETUP.md)
