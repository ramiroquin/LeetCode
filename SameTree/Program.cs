﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Same tree node!");

        TreeNode p = new TreeNode();
        TreeNode q = new TreeNode();
        
        IsSameTree(p, q);

        
    }

    

    public static void IsSameTree(TreeNode p, TreeNode q)
    {

    }
}


// Arbol binario
public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}