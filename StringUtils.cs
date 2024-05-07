using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContarPalabras
{
    // Clase StringUtils
    public class StringUtils
    {
        // Método para contar la cantidad de palabras en una cadena
        public int CountWords(string input)
        {
            // Verificar si la cadena está vacía
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            // Dividir la cadena en palabras usando los espacios en blanco como separadores
            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Devolver la cantidad de palabras
            return words.Length;
        }

        // Método para invertir una cadena
        public string ReverseString(string input)
        {
            // Crear un arreglo de caracteres a partir de la cadena
            char[] charArray = input.ToCharArray();

            // Invertir el orden de los caracteres en el arreglo
            Array.Reverse(charArray);

            // Convertir el arreglo de caracteres de vuelta a una cadena y devolverla
            return new string(charArray);
        }
    }

    // Programa principal
    class Program
    {
        static void Main(string[] args)
        {
            StringUtils stringUtils = new StringUtils();

            // Ejemplo de uso del método CountWords
            string sentence = "Hola, este es un ejemplo de cadena.";
            int wordCount = stringUtils.CountWords(sentence);
            Console.WriteLine($"La cadena '{sentence}' tiene {wordCount} palabras.");

            // Ejemplo de uso del método ReverseString
            string originalString = "Programación en C#";
            string reversedString = stringUtils.ReverseString(originalString);
            Console.WriteLine($"La cadena '{originalString}' invertida es: '{reversedString}'");

            Console.ReadLine();
        }
    }
}
