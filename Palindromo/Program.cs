internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Palindromo");

        Console.WriteLine("Ingrese un numero: ");
        int numero = int.Parse(Console.ReadLine());
        bool esPalindromo = IsPalindrome(numero);
        Console.WriteLine(esPalindromo);
    }

    static bool IsPalindrome(int x)
    {
        // Verifica si el número es negativo.
        if (x < 0)
        {
            // Los números negativos nunca son palíndromos.
            return false;
        }

        // Inicializa dos variables, una para el número original y otra para el número invertido.
        int original = x;
        int inverso = 0;

        // Usa un bucle while para invertir los dígitos del número original.
        while (x != 0)
        {
            // Obtén el último dígito del número original.
            int digito = x % 10;

            // Agrega el dígito al número invertido, multiplicando por 10 y sumando el dígito.
            inverso = inverso * 10 + digito;

            // Elimina el último dígito del número original.
            x /= 10;
        }

        // Paso 4: Compara el número original con el número invertido.
        return original == inverso;

    }
}