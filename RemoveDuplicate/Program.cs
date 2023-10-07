using System.ComponentModel;
using System.Xml;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Remove duplicate");

        int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

        RemoveDuplicates(nums);
    }

    static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        int elementoUnico = 1;  // Al menos un elemento único (el primero)

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[elementoUnico] = nums[i];
                elementoUnico++;
            }
        }

        return elementoUnico;
    }
}