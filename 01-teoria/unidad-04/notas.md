# Condicionales 2 - operadores logicos y switch en C#

---

## Operadores lógicos

Los operadores lógicos se utilizan para **combinar condiciones** o **negar su resultado**.  
Siempre trabajan con valores booleanos (`true` o `false`).

---

### AND lógico `&&`

Se utiliza cuando **todas las condiciones deben cumplirse** para que la expresión sea verdadera.

```csharp
if (edad >= 18 && tieneEntrada)
{
    Console.WriteLine("Puede ingresar");
}
```

Si una sola condición es falsa, el resultado final es false.

Tabla de verdad AND (&&)

| Condición A | Condición B | Resultado |
| ----------- | ----------- | --------- |
| true        | true        | true      |
| true        | false       | false     |
| false       | true        | false     |
| false       | false       | false     |

### OR lógico `||`

Se utiliza cuando al menos una condición debe ser verdadera.

```csharp
if (esAdmin || esSupervisor)
{
    Console.WriteLine("Acceso permitido");
}
```

Tabla de verdad OR (||)

| Condición A | Condición B | Resultado |
| ----------- | ----------- | --------- |
| true        | true        | true      |
| true        | false       | true      |
| false       | true        | true      |
| false       | false       | false     |

### NOT lógico !

Se utiliza para invertir el valor de una condición.

```csharp
if (!estaBloqueado)
{
    Console.WriteLine("Usuario habilitado");
}
```

Tabla de verdad NOT (!)

| Condición | Resultado |
| --------- | --------- |
| true      | false     |
| false     | true      |

---

## Condicional if / else

Se utiliza cuando el programa debe decidir entre dos caminos posibles según una condición.

```csharp
if (numero > 0)
{
    Console.WriteLine("Número positivo");
}
else
{
    Console.WriteLine("Número negativo o cero");
}
```

### else if

Se utiliza cuando existen más de dos posibilidades, cada una con su propia condición.

```csharp
if (nota >= 8)
{
    Console.WriteLine("Aprobado");
}
else if (nota >= 6)
{
    Console.WriteLine("Regular");
}
else
{
    Console.WriteLine("Desaprobado");
}
```

# Condicional switch

El switch se utiliza cuando se compara una misma variable contra valores concretos.
Es especialmente útil para menús de opciones.

## Estructura básica del switch

Cada case representa una opción válida.
El break finaliza la ejecución del switch.

```csharp
switch (opcion)
{
    case 1:
        // código
        break;

    case 2:
        // código
        break;

    default:
        // opción no válida
        break;
}
```

## switch aplicado a un menú

Cada case corresponde a una opción válida elegida por el usuario.
El default se utiliza para manejar opciones no válidas.

```csharp
switch (opcion)
{
    case 1:
        Console.WriteLine("Sumar");
        break;

    case 2:
        Console.WriteLine("Restar");
        break;

    case 0:
        Console.WriteLine("Salir");
        break;

    default:
        Console.WriteLine("Opción no válida");
        break;
}
```

---

# Comparación if vs switch

```text
Usar if cuando:

- Se evalúan rangos (>, <)
- Se combinan condiciones (&&, ||)
- La lógica es más compleja

Usar switch cuando:

- Se evalúa una sola variable
- Hay valores fijos
- Se implementan menús

```

---

### Tipos de datos admitidos en `switch`

En C#, la expresión evaluada en un `switch` puede ser de distintos tipos de datos.  
Los más usados en condicionales básicos son:

- `int` → números enteros
- `char` → un solo carácter
- `string` → texto

Cada `case` debe coincidir exactamente con el valor evaluado.

---

#### `switch` con números (`int`)

```csharp
int opcion = 1;

switch (opcion)
{
    case 1:
        Console.WriteLine("Opción uno");
        break;

    case 2:
        Console.WriteLine("Opción dos");
        break;
}
```

#### switch con caracteres (char)

```csharp
char letra = 'A';

switch (letra)
{
    case 'A':
        Console.WriteLine("Letra A");
        break;

    case 'B':
        Console.WriteLine("Letra B");
        break;
}
```

#### switch con cadenas (string)

```csharp
string dia = "lunes";

switch (dia)
{
    case "lunes":
        Console.WriteLine("Inicio de semana");
        break;

    case "viernes":
        Console.WriteLine("Fin de semana cerca");
        break;
}

```

```text
Nota importante

- En char se usan comillas simples ('A')
- En string se usan comillas dobles ("lunes")
- El switch compara valores exactos, no rangos

switch acepta:
- int y otros enteros
- char
- string
- bool (mejor usar if, porque hay solo dos opciones)
- enum

switch NO sirve para:
- rangos
- condiciones lógicas

```
