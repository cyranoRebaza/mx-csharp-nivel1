# Declaracion de una variable con asignacion

```text
tipoDato nombreVariable = valor;

```

- tipoDato: que tipo de dato va a guardar
- nombreVariable: como se llama la variable
- = : operador de asignacion
- valor: dato que se guarda

```csharp
int edad = 30;

```

# Declaracion de una variable sin asignación

```csharp
int edad;
edad = 30;

```

---

# Tipo de datos en C#

- [int](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types): enteros
- [float](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types): decimal (menos preciso)
- double: decimal general
- decimal: dinero (mas preciso)
- char: un solo caracter
- bool: verdadero o falso
- string: texto

# usos mas comunes

## int - cantidad / contadores

se usa cuando no hay decimales - edad - cantidad de productos - numero de intentos

```csharp
int cantidadProductos = 12;

```

## float - graficos o videojuegos

se usa cuando importa el rendimiento no la precisión

    - posición en pantalla
    - velocidad
    - coordenadas

```csharp
float velocidadJugador = 4.5f;
float pocision = 2.0F;

```

## double - calculos generales

El mas usado con numeros decimales

    - promedios
    - temperaturas
    - mediciones

```csharp
double temperatura = 27.8;

```

## Decimal - finanzas / dinero

se usa cuando la precisión es crítica

    - precios
    - salarios
    - saldos

```csharp
decimal precioProducto = 1999.99m;
decimal saldo = 125.25D;
```

## char - un solo caracter

para representar una letra o simbolo

    - inicial
    - categoria
    - estados simple

```csharp
char categoria = 'A';
```

## string - texto

Para informacion textual

    - nombres
    - mensajes

```csharp
string nombreCliente = "Juan Perez";
```

## bool - Estados lógicos

Para deciciones y condiciones

    - Activo / inactivo
    - Aprobado / no aprobrado
    - mayor de edad

```csharp
bool esMayorEdad = true;
```

---

# Diferencias entre Parse() - Convert() - TryParse()

Parse() -> rápido, rompe si falla, solo string
Convert() -> más flexible, acepta null, igual puede romper
TryParse() -> seguro, recomendado para input real

## xx.Parse()

- convierte un string al tipo de dato indicado
- se usa cuando estoy seguro que el dato es valido

```csharp
int numero = int.Parse("123"); // ok
int numero2 = int.Parse("abc"); // FormartException
```

- lanza excepción cuando:
  - El string no es valido
  - Es null
  - Esta fuera de rango

## Convert.ToXX()

- convierte distintos tipos de datos no solo string
- Acepta null
-

```csharp
int n1 = Convert.ToInt32("123"); // OK
int n3 = Convert.ToInt32("abc"); // FormatException
int n2 = Convert.ToInt32(null);  // devuelve 0

```

---

## TryParse() - avanzando

- Si el dato viene de usuario, API, archivo
- No lanza excepciones
- es un metodo que devuelve dos valores
  - ¿Se pudo convertir? → true / false
  - El número convertido → int

  Entonces hace esto:

        - return → me dice si o no

        - out → me devuelve el dato convertido

- TryParse existe solo para tipos simples(int,double, bool, DateTime)
- no falla, devuelve false
- El out queda en valor por defecto
- algunos tipos dependen del formato (fecha,decimales)

### firma del metodo

```csharp
bool int.TryParse(string? s, out int result)
```

Intento convertir s a int,te digo si pude,y si pude, te dejo el número en result”.

Ejemplo:

```csharp
string texto = "25";

bool pudo = int.TryParse(texto, out int numero);

Console.WriteLine(pudo);   // true
Console.WriteLine(numero); // 25

```

```csharp
string texto = "abc";

bool pudo = int.TryParse(texto, out int numero);

Console.WriteLine(pudo);   // false
Console.WriteLine(numero); // 0 (valor por defecto)

```

```csharp
int numero; // declarada antes

bool pudo = int.TryParse("42", out numero);

if (pudo)
{
    Console.WriteLine(numero);
}

```
