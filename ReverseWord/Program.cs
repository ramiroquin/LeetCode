internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Reverse Words in String III");

        string cadena = ReverseWords("hola como");
        
    }

    static string ReverseWords(string cadena)
    {
        string[] palabras = cadena.Split(" ");
        List<string> listaPalabras = new List<string>();

        foreach (string palabra in palabras)
        {
            char[] caracterInvertido = palabra.Reverse().ToArray();
            string cadenaInvertida = new string(caracterInvertido);
            listaPalabras.Add(cadenaInvertida);
        }

        string cadenaResultado = string.Join(" ", listaPalabras);

        return cadenaResultado;
    }
}