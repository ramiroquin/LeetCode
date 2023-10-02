using System.ComponentModel;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Encriptar!");

        Bit13("rabl");

    }

    static void Bit13(string cadena)
    {
        // Lista para guardar cada letra
        List<string> lista = new List<string>();

        string abecedario = "abcdefghijklmnñopqrstuvwxyz";

        // Saca los espacios a las cadenas
        string cadenaSinEspacios = cadena.Replace(" ", "");


        foreach (char letra in cadenaSinEspacios)
        {
            // indice de cada letra que recorre el for a la cadena
            int indice = abecedario.IndexOf(letra);
            if (indice != -1)
            {
                string resultadoReal = "";
                for (int i = 0; i < 14; i++)
                {
                    int nuevoIndice = (indice + i) % abecedario.Length;
                    resultadoReal += abecedario[nuevoIndice];
                }
                lista.Add(resultadoReal);
            }
        }

        foreach (var item in lista)
        {
            Console.Write(item);
        }
    }

}