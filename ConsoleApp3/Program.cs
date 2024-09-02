using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Diccionario inicial de traducción
        Dictionary<string, string> dictionary = new Dictionary<string, string>
        {
            { "time", "tiempo" },
            { "person", "persona" },
            { "year", "año" },
            { "way", "camino/forma" },
            { "day", "día" },
            { "thing", "cosa" },
            { "man", "hombre" },
            { "world", "mundo" },
            { "life", "vida" },
            { "hand", "mano" },
            { "part", "parte" },
            { "child", "niño/a" },
            { "eye", "ojo" },
            { "woman", "mujer" },
            { "place", "lugar" },
            { "work", "trabajo" },
            { "week", "semana" },
            { "case", "caso" },
            { "point", "punto/tema" },
            { "government", "gobierno" },
            { "company", "empresa/compañía" }
        };

        while (true)
        {
            Console.WriteLine("\nMENU");
            Console.WriteLine("=======================================================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Ingresar más palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    TranslatePhrase(dictionary);
                    break;
                case "2":
                    AddWordsToDictionary(dictionary);
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }

    static void TranslatePhrase(Dictionary<string, string> dictionary)
    {
        Console.Write("Ingrese la frase: ");
        string input = Console.ReadLine();
        string[] words = input.Split(' ');
        List<string> translatedWords = new List<string>();

        foreach (string word in words)
        {
            string lowerWord = word.ToLower().Trim(new char[] { '.', ',', '!', '?' });
            if (dictionary.ContainsKey(lowerWord))
            {
                translatedWords.Add(dictionary[lowerWord]);
            }
            else
            {
                translatedWords.Add(word);
            }
        }

        Console.WriteLine("Su frase traducida es: " + string.Join(" ", translatedWords));
    }

    static void AddWordsToDictionary(Dictionary<string, string> dictionary)
    {
        Console.Write("Ingrese la palabra en inglés: ");
        string englishWord = Console.ReadLine().ToLower();
        Console.Write("Ingrese la traducción en español: ");
        string spanishWord = Console.ReadLine();

        if (dictionary.ContainsKey(englishWord))
        {
            Console.WriteLine("La palabra ya existe en el diccionario.");
        }
        else
        {
            dictionary.Add(englishWord, spanishWord);
            Console.WriteLine("Palabra añadida al diccionario.");
        }
    }
}
