
internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Palabra("hola fachero sos fachero");
    }

    public static void Palabra(string cadena)
    {
        
        String[] palabras = cadena.Split(' ');
        
        Dictionary<String, int> frecuenciaPalabras = new Dictionary<String, int>();

        foreach (String palabra in palabras)
        {
            Console.WriteLine(palabra);

            if (frecuenciaPalabras.ContainsKey(palabra))
            {
                frecuenciaPalabras[palabra]++;
            }
            else
            {
                frecuenciaPalabras[palabra] = 1;
            }
        }

        foreach (var kvp in frecuenciaPalabras)
        {
            Console.WriteLine($"la palabra {kvp.Key} se repitio {kvp.Value} veces");
        }

        

    }
}