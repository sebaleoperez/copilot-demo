using System;

Console.WriteLine("¡Bienvenido a la Calculadora!");
Console.WriteLine("==============================");

var calculadora = new Calculadora();

// Demostrar la funcionalidad de raíz cuadrada
Console.WriteLine("\n--- Ejemplos de Raíz Cuadrada ---");

double[] numeros = { 4, 9, 16, 25, 36, 49, 64, 81, 100 };

foreach (double numero in numeros)
{
    try
    {
        double resultado = calculadora.RaizCuadrada(numero);
        Console.WriteLine($"√{numero} = {resultado}");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}

// Ejemplo con número decimal
Console.WriteLine($"√2.25 = {calculadora.RaizCuadrada(2.25)}");

// Ejemplo de manejo de error con número negativo
Console.WriteLine("\n--- Manejo de Errores ---");
try
{
    calculadora.RaizCuadrada(-4);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error al calcular √(-4): {ex.Message}");
}

Console.WriteLine("\n--- Otras Operaciones Básicas ---");
Console.WriteLine($"5 + 3 = {calculadora.Sumar(5, 3)}");
Console.WriteLine($"10 - 4 = {calculadora.Restar(10, 4)}");
Console.WriteLine($"6 × 7 = {calculadora.Multiplicar(6, 7)}");
Console.WriteLine($"15 ÷ 3 = {calculadora.Dividir(15, 3)}");
