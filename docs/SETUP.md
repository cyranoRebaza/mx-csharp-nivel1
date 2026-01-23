# Setup y flujo de trabajo – C# Nivel 1

Este documento describe el flujo de trabajo utilizado para:
- crear la solución base
- organizar teoría y ejercicios por unidades
- crear proyectos de consola en C#
- versionar el progreso con Git y GitHub
- mantener compatibilidad entre VS Code y Visual Studio

---

## Requisitos

- .NET SDK 8.0 o superior
- Git
- Cuenta de GitHub
- Visual Studio Code o Visual Studio

---

## 1. Crear solución base (una sola vez)

```bash
mkdir mx-csharp-nivel1
cd mx-csharp-nivel1
dotnet new sln -n mx-csharp-nivel1

mkdir 01-teoria
mkdir 02-ejercicios

dotnet new gitignore
git init
git add .
git commit -m "Estructura inicial del curso C# Nivel 1"


```

## 2. Crear repositorio en GitHub

Repositorio remoto:

- Nombre: mx-csharp-nivel1

- Sin README, .gitignore ni licencia

```bash
git branch -M main
git remote add origin https://github.com/TU_USUARIO/mx-csharp-nivel1.git
git push -u origin main

```

## 3. Crear una nueva unidad

Ejemplo: Unidad 01

```bash
mkdir 01-teoria/unidad-01
mkdir 02-ejercicios/unidad-01

```

## 4. Crear un nuevo ejercicio

Convención de nombres

Unidad: U01

Ejercicio: EJ01

Proyecto / Namespace: U01_EJ01

Se utiliza guion bajo (_) para que .NET genere automáticamente el namespace correcto.

Ejemplo: Unidad 01 – Ejercicio 01

```bash
mkdir 02-ejercicios/unidad-01/ejercicio-01
cd 02-ejercicios/unidad-01/ejercicio-01

dotnet new console -n U01_EJ01

cd ../../../..
dotnet sln mx-csharp-nivel1.sln add 02-ejercicios/unidad-01/ejercicio-01/U01_EJ01.csproj


```

## 5. Commit por ejercicio

Ejemplo: Unidad 01 – Ejercicio 01

```bash
git add .
git commit -m "Unidad 01 - Ejercicio 01"
git push

```