# COMANDOS – Flujo de trabajo C# Nivel 1

Este documento resume los comandos más usados durante el curso para
organizar teoría, ejercicios y versionar el progreso con Git y GitHub.

---

## Nota importante sobre las rutas

En los ejemplos se utiliza:

```bash
cd ~/mx-csharp-nivel1
```

~ representa la carpeta home del usuario.

La ruta debe ajustarse según dónde esté ubicado el repositorio en tu sistema.

Ejemplos:

~/mx-csharp-nivel1

~/proyectos/mx-csharp-nivel1

~/workspace/mx-csharp-nivel1

1. Volver a la raíz del repositorio

Usar siempre antes de trabajar con Git o la solución

```bash
cd ~/mx-csharp-nivel1

```

O, si estás dentro de subcarpetas:

```bash
cd ../../..

```

2. Crear una nueva unidad (estructura base)

Ejemplo: Unidad 01

```bash
mkdir -p 01-teoria/unidad-01
mkdir -p 02-ejercicios/unidad-01

```

3. Crear archivos base de la unidad (teoría)

```bash
cd 01-teoria/unidad-01
touch README.md notas.md

```

- README.md: objetivos y temas de la unidad
- notas.md: apuntes generales de la unidad

4. Crear carpeta de tema de teoría (referencia: Bienvenida)

Este patrón se repite para todos los temas de teoría.

```bash
mkdir 01-bienvenida
cd 01-bienvenida
touch notas.md

```

- Algunos temas tendrán solo notas
- Otros temas incluirán notas + proyecto de código

5. Crear proyecto de consola dentro de teoría (cuando hay código)

Ejemplo: Unidad 01 – Tema 08 (Hola Mundo)

Convención:

    - Unidad: U01
    - Tema: T08
    - Proyecto / Namespace: U01_T08_HolaMundo

```bash
cd 01-teoria/unidad-01/08-hola-mundo
dotnet new console -n U01_T08_HolaMundo

```

Volver a la raíz y agregar a la solución:

```bash
cd ../../../..
dotnet sln mx-csharp-nivel1.sln add 01-teoria/unidad-01/08-hola-mundo/U01_T08_HolaMundo/U01_T08_HolaMundo.csproj

```

Probar el proyecto:

```bash
cd 01-teoria/unidad-01/08-hola-mundo/U01_T08_HolaMundo
dotnet run

```

6. Crear un ejercicio práctico (02-ejercicios)

Ejemplo: Unidad 01 – Ejercicio 01

Convención:

    - Proyecto / Namespace: U01_EJ01

```bash
mkdir 02-ejercicios/unidad-01/ejercicio-01
cd 02-ejercicios/unidad-01/ejercicio-01
dotnet new console -n U01_EJ01

cd ../../../..
dotnet sln mx-csharp-nivel1.sln add 02-ejercicios/unidad-01/ejercicio-01/U01_EJ01/U01_EJ01.csproj

```

7. Flujo básico de Git

Antes de commitear:

    - Guardar archivos
    - Verificar cambios

```bash
git status

```

Commit y push:

```bash
git add .
git commit -m "Mensaje claro y descriptivo"
git push

```

Tips importantes

- Ejecutar Git siempre desde la raíz del repositorio
- Un commit representa un cambio lógico
- Teoría con código → notas + proyecto
- Teoría sin código → solo notas
- Un proyecto por ejercicio
