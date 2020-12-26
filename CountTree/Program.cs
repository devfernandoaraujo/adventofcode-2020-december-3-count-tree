using System;

namespace CountTree
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateTrees trees = new CalculateTrees();

            Console.WriteLine("The quantity of tress is {0}", trees.GetNumberOfTrees());
            Console.WriteLine("Multiplying the number of trees is equal to {0}", trees.multiplySlopesOfTrees());
        }
    }
}
