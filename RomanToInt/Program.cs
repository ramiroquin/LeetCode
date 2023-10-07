using System.Security.AccessControl;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

       int resultado =  RomanToInt("LV");
    }

    public static int RomanToInt(string s)
    {
        int contador = 0;

        char[] cadena = s.ToUpper().ToCharArray();

        IDictionary<string, int> numeroRomanos = new Dictionary<string, int>
    {
        {"I", 1},{"V", 5}, {"X", 10}, {"L", 50},
        {"C", 100}, {"D", 500}, {"M", 1000}
    };

        for (int i = 0; i < cadena.Length; i++)
        {
            string currentSymbol = cadena[i].ToString();

            if (numeroRomanos.ContainsKey(currentSymbol))
            {
                int currentValue = numeroRomanos[currentSymbol];

                if (i < cadena.Length - 1)
                {
                    string nextSymbol = cadena[i + 1].ToString();
                    int nextValue = numeroRomanos[nextSymbol];

                    if (currentValue < nextValue)
                    {
                        if ((currentSymbol == "I" && (nextSymbol == "V" || nextSymbol == "X")) ||
                            (currentSymbol == "X" && (nextSymbol == "L" || nextSymbol == "C")) ||
                            (currentSymbol == "C" && (nextSymbol == "D" || nextSymbol == "M")))
                        {
                            contador -= currentValue;
                        }
                        else
                        {
                            Console.WriteLine("Las letras romanas deben estar en orden decreciente.");
                            return -1; // Devolver un valor especial para indicar un error
                        }
                    }
                    else
                    {
                        contador += currentValue;
                    }
                }
                else
                {
                    contador += currentValue;
                }
            }
            else
            {
                Console.WriteLine("La cadena contiene caracteres no válidos.");
                return -1; // Devolver un valor especial para indicar un error
            }
        }

        return contador;
    }

}