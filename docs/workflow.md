# Workflow de trabajo – C# Nivel 1

Este documento describe el flujo de trabajo utilizado durante el curso
para organizar la teoría, los ejercicios y el versionado con Git.

El objetivo es mantener un proceso claro, repetible y ordenado.

---

## Workflow general

1. Crear o identificar la unidad de trabajo
2. Documentar teoría y apuntes
3. Resolver ejercicios prácticos
4. Versionar el progreso con Git

---

## Workflow para teoría

Este flujo se aplica al iniciar y avanzar en una unidad.

### Al comenzar una unidad
1. Crear carpeta de la unidad en `01-teoria/`
2. Crear `README.md` de la unidad con:
   - temas
   - objetivos
   - ejercicios asociados
3. Crear `notas.md` vacío

### Durante la unidad
- Agregar apuntes en `notas.md`
- Registrar:
  - conceptos importantes
  - comandos usados
  - errores comunes
  - tips personales
  - dudas

### Al finalizar la unidad
- Revisar y ordenar `notas.md`
- Commit de la teoría y apuntes

---

## Workflow para ejercicios

Cada ejercicio se trata como un proyecto independiente.

1. Crear carpeta de ejercicio dentro de la unidad correspondiente
2. Crear el proyecto de consola con nombre válido para namespace (`UXX_EJYY`)
3. Agregar el proyecto a la solución
4. Resolver el ejercicio
5. Verificar funcionamiento con `dotnet run`
6. Commit del ejercicio terminado

---

## Workflow de Git

Reglas generales de versionado:

- Guardar archivos antes de commitear
- Usar mensajes de commit en modo imperativo
- Realizar un commit por ejercicio terminado
- Evitar commits grandes y poco claros

### Flujo típico de Git

```bash
git status
git add .
git commit -m "Mensaje claro y descriptivo"
git push

```