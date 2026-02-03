# Condicionales (if / else)

## ¿Qué es un condicional?

Un condicional permite que el programa tome decisiones y ejecute código
solo si se cumple una condición (true o false).

## Estructura básica

```csharp
if (condicion)
{
    // código si la condición es verdadera
}
```

## Operadores relacionales

```text
> mayor
< menor
>= mayor o igual
<= menor o igual
== igual
!= distinto

⚠️ = asigna
⚠️ == compara

```

## If / Else

```csharp
if (edad > 18)
{
    Console.WriteLine("Mayor");
}
else
{
    Console.WriteLine("Menor");
}
```

## Diferencia entre acumulador y contador

- Contador: cuenta casos

- Acumulador: suma valores

### Contador

Sirve para contar cuántas veces ocurre algo.
Siempre se inicializa en 0.

```csharp
int contador = 0;

if (numero < 100)
{
    contador++;
}
```

### Acumulador

Sirve para sumar valores que cumplen una condición.

```csharp
int acumulador = 0;

if (numero > 100)
{
    acumulador += numero;
}
```

## Operador módulo (%)

Devuelve el resto de una división.

```csharp
if (numero % 2 == 0)
{
    Console.WriteLine("Par");
}
else
{
    Console.WriteLine("Impar");
}
```

### If + módulo + contador

```csharp
int contadorPares = 0;

if (numero % 2 == 0)
{
    contadorPares++;
}

```
