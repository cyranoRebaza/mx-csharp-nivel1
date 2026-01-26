# Unidad 01 - Resumen práctico

## Crear proyectos de consola

### usando `-n`

```bash
dotnet new console -n NombreProyecto --use-program-main

```

- Crea una carpeta con el nombre del proyecto
- El .csproj y el namespace usan ese nombre

### usando -o

```bash
dotnet new console -o ruta/NombreProyecto

```

- -o define donde se crea el proyecto
- El nombre del proyecto sale del nombre de la carpeta

## Navegación en la terminal

- pwd: muestra la ruta actual
- ls / dir: lista archivos y carpetas
- cd carpeta: entrar
- cd.. subir un nivel

## Ejecutar un proyecto

```bash
dotnet run

```

- Debe ejecutarse desde la carpeta donde esta el .csproj

## Soluciones(.sln)

- Una solución agrupa proyectos
- Un proyecto pertenece a la solución si esta agregado

ver proyectos en la solución:

```bash
dotnet sln list
```

Agregar un proyecto

```bash
dotnet sln add ruta/Proyecto.csproj
```
