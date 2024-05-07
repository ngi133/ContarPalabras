// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ContarPalabras;

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