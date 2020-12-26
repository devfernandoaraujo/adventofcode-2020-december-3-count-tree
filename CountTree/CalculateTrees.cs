using System;
using System.Collections.Generic;
using System.Linq;

namespace CountTree
{
    public class CalculateTrees
    {

        private List<string> puzzle = null;

        public CalculateTrees()
        {
            this.puzzle = Puzzle.GetPuzzleInput();
        }

        /// <summary>
        /// Find the trees
        /// </summary>
        /// <param name="slope">Number of spots to the right</param>
        /// <param name="down">number of spots down</param>
        /// <returns>Integer value </returns>
        public int GetNumberOfTrees(int slope = 3, int down = 1)
        {

            int quantityOfItems = this.puzzle.Count - 1;
            int numberOfTrees = 0;
            int stringPosition = 0;
            int i = 0;
            while (i < quantityOfItems)
            {
                //Next line

                //Move to the next position on the tree
                stringPosition += slope;

                if (stringPosition >= this.puzzle[i].Length)
                {
                    Puzzle.ExtendList(this.puzzle);
                }

                if (this.puzzle[i + down].ToCharArray()[stringPosition] == '#')
                {
                    numberOfTrees++;
                }

                i += down;
            }


            return numberOfTrees;
        }

        /// <summary>
        /// multiply the number of trees found on on the slopes 
        /// </summary>
        /// <returns>Integer value</returns>
        public long multiplySlopesOfTrees()
        {

            long[] total = new long[5];
            //First Column means right position
            //Second Column means down position
            int[,] slopes = {
                                {1,1},
                                {3,1},
                                {5,1},
                                {7,1},
                                {1,2}
                            };


            for (int l = 0; l < slopes.GetLength(0); l++)
            {
                total[l] = this.GetNumberOfTrees(slopes[l, 0], slopes[l, 1]);
            }


            return total.Aggregate((a, b) => a * b);
        }
    }

}