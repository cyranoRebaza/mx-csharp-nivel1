# Primer programa explicado en diagramas

## Diagrama de flujo - figuras

El diagrama muestra el flujo de ejecucion de un programa

1. Inicio del programa -> circulo con I
2. Ingreso de datos -> trapecio invertido
3. Proceso -> rectangulo
4. Salida -> trapecio normal
5. Fin del programa -> circulo con F

### Ejemplo

Pedir dos numeros y mostrar la suma

1. Inicio del programa
2. Pido los datos -> n1,n2
3. Proceso -> r = n1 + n2
4. Salida información -> r
5. Fin del programa

---

## Dato - Proceso - Informacion

### Dato

Un dato es un conjunto de simbolos sin significado

### Información

Son simbolos que tienen algun significado

### Proceso

El procesamiento es la conversión o transformación de datos en informmación a
traves de pasos estructurados

---

## Variables

Una variable representa un espacio en memoria que permite alojar un valor
o dato para poder usarla despues.

- es como un fraquito con una etiquetapara guardar algo
- una variable guarda un valor para despues usarla
- solo puede guardar un dato a la vez
- El nombre de la variable debe representar su contenido
- si lo comparamos con excel una celda C5 seria la DIRECCIÓN DE MEMORIA de esa celda (variables)

### consideraciones para dar nombres a las variables

- no debene tener espacios
- no puede contener simbolos especiales
- no puedo usar palabras reservas como nombre de variable

## Ejemplo

Pedir dos numeros y mostrar la suma

1. Inicio del programa
2. Pido los datos -> n1,n2
3. Proceso -> r = n1 + n2
4. Salida información -> r
5. Fin del programa

---

# Operadores

- Aritmeticos: + - \* / %
- Relacionales: == != > < >= <=
- Lógicos: && || !
- Asignacion
  - Asignacion simple: =
  - Asignación compuesta: += -= \*= /=

## Asignación simple

La asignación es darle valor a una variable

```csharp
int numero = 10;
```

## Asignación compuesta o reducida

Toman el valor actual de la variable, hacen una operacion
y guardan el resultado EN LA MISMA VARIABLE

```csharp
int numero = 10;

numero += 5; // numero = numero + 5 -> 15
numero -= 2; // numero = numero - 2 -> 13
numero *= 2; // numero = numero * 2 -> 26
numero /= 2; // numero = numero / 2 -> 13
```

---

## Primer programa con C#

la suma de de dos numeros

```csharp
// Declarar las variables y darles un tipo de dato(int float,char,bool)
int numero1;
int numero2;
int resultado;

// Pedir datos por teclado con la funcion ReadLine. esta devuelve un texto
// con int.Parse lo transformamos a numeros
numero1 = int.Parse(Console.ReadLine());
numero2 = int.Parse(Console.ReadLine());

// Proceso
resultado = numero1 + numero2;

// Mostrar
Console.WriteLine(resultado);

```
