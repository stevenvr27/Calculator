using System;

namespace CalculatorApp
{
    public class Calculator
    {
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public double Divide(int num1, int num2)
        {
            // Verificar la división por cero
            if (num2 == 0)
            {
                throw new ArgumentException("No se puede dividir por cero.");
            }

            return (double)num1 / num2;
        }
    }

    class Program
    {
        private static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            // Pruebas manuales
            Console.WriteLine("Suma de 5 y 3: " + calculator.Sum(5, 3));
            Console.WriteLine("Resta de 10 y 4: " + calculator.Subtract(10, 4));
            Console.WriteLine("Multiplicación de 6 y 7: " + calculator.Multiply(6, 7));

            try
            {
                Console.WriteLine("División de 20 entre 0: " + calculator.Divide(20, 0));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
