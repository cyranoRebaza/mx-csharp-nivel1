# unidad 5 - ciclos for - while - do while

## Ciclos (Bucles)

Un ciclo es una estructura de la programación que permite repetir una o varias instrucciones varias veces sin necesidad de escribir el mismo código repetidamente.

Ejemplo sin ciclos:

```csharp
Console.WriteLine("Hola mundo");
Console.WriteLine("Hola mundo");
Console.WriteLine("Hola mundo");
Console.WriteLine("Hola mundo");
Console.WriteLine("Hola mundo");
```

Con un ciclo, la instrucción se escribe una sola vez y se repite automáticamente.

---

## Ciclo for (ciclo exacto)

El ciclo for se utiliza cuando sabemos de antemano cuántas veces queremos repetir un bloque de código.
Se lo llama ciclo exacto porque da exactamente la cantidad de vueltas configuradas.

### Estructura del for

```csharp
for (inicialización; condición; incremento)
{
    // instrucciones a repetir
}
```

Partes del ciclo

- Inicialización
  Se ejecuta una sola vez. Define el valor inicial de la variable del ciclo.
  Usualmente comienza en 0.

- Condición
  Se evalúa antes de cada vuelta.
  Si es true, el ciclo continúa.
  Si es false, el ciclo termina.

- Incremento
  Modifica la variable del ciclo para evitar ciclos infinitos.
  Lo más común es i++.

### Configuración estándar

Para repetir 10 veces:

```text
i = 0
i < 10
i++
```

Ejemplo:

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Hola mundo");
}
```

---

## Ciclo while (ciclo inexacto)

El ciclo while se usa cuando no se conoce la cantidad exacta de repeticiones, y el ciclo depende de una condición.

- La condición se evalúa antes de entrar al ciclo.
- Si es falsa desde el inicio, el ciclo no se ejecuta.

Ejemplo:

```csharp
int n = 0;

while (n < 10)
{
    n++;
    Console.WriteLine(n);
}
```

El ciclo se repite mientras n sea menor que 10.

---

## Ciclo do while

Funciona de forma similar al while, pero con una diferencia clave:

- El bloque se ejecuta al menos una vez, ya que la condición se evalúa al final.

Ejemplo:

```csharp
int n = 0;

do
{
    n++;
}
while (n < 10);
```
