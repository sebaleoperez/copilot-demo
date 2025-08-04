public class Calculadora
{
    /// <summary>
    /// Calcula la raíz cuadrada de un número
    /// </summary>
    /// <param name="numero">El número del cual calcular la raíz cuadrada</param>
    /// <returns>La raíz cuadrada del número</returns>
    /// <exception cref="ArgumentException">Se lanza cuando el número es negativo</exception>
    public double RaizCuadrada(double numero)
    {
        if (numero < 0)
        {
            throw new ArgumentException("No se puede calcular la raíz cuadrada de un número negativo");
        }
        return Math.Sqrt(numero);
    }

    /// <summary>
    /// Suma dos números
    /// </summary>
    public double Sumar(double a, double b)
    {
        return a + b;
    }

    /// <summary>
    /// Resta dos números
    /// </summary>
    public double Restar(double a, double b)
    {
        return a - b;
    }

    /// <summary>
    /// Multiplica dos números
    /// </summary>
    public double Multiplicar(double a, double b)
    {
        return a * b;
    }

    /// <summary>
    /// Divide dos números
    /// </summary>
    /// <exception cref="DivideByZeroException">Se lanza cuando el divisor es cero</exception>
    public double Dividir(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("No se puede dividir por cero");
        }
        return a / b;
    }
}