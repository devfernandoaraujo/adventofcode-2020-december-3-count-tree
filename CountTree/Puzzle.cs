using System;
using System.Collections.Generic;

namespace CountTree
{


    /// <summary>
    /// Class with Entries  for the challenge
    /// </summary>

    internal static class Puzzle
    {



        /// <summary>
        /// Puzzle reference Tree count
        /// </summary>
        /// <returns>
        /// List of strings
        /// </returns>
        internal static List<string> GetPuzzleInput()
        {   //The sequence keep repeating on the right side ---->
            List<string> lst = new List<string>(){
                    ".#...#.......#...#...#.#.#.....",
                    "####.....#.#..#...#...........#",
                    ".....#...........#......#....#.",
                    "......#..#......#.#..#...##.#.#",
                    "............#......#...........",
                    "...........#.#.#....#.......##.",
                    "....#.......#..............#...",
                    "........##...#.#.....##...##.#.",
                    ".#.#.....##................##..",
                    ".##................##..#...##..",
                    "....#...###...##.........#....#",
                    ".##......#.........#...........",
                    "...#.#.#....#....#...#...##...#",
                    "..#....##...#..#.#..#.....#.#..",
                    ".......#...#..#..#.....#...#..#",
                    ".....#......#.......#.....#.#..",
                    "....#..#...#..#####....##......",
                    ".#...........#......#....#....#",
                    "#......#.###.....#....#....#...",
                    "....#..#.#.#..#...........##...",
                    "..#..#..#.#...#......#....#.##.",
                    ".##....#......#...#.#..#.......",
                    "..###.#...#.........#.#.#...#.#",
                    "#....###.........#...#...#...#.",
                    "...##.#............#...##......",
                    "...#.........#............#....",
                    "......##...#...##..#...........",
                    "........##..#.#.####...#.....#.",
                    ".##.........#......#..#..#...#.",
                    "..........#...#..........#.....",
                    "#..........#........#..#..#.#..",
                    "..#....#.#.#.#.#..#.##.........",
                    "##.#.#.##.....#..#......###....",
                    "##....#...#.....#..............",
                    ".#..#...#...#....###......#....",
                    "#....#......#.#..#.#........###",
                    ".#....#..#...###....#...##.....",
                    ".#....#.....#.....#..##..#.....",
                    "#....#.##...#...#..#.##.##.#...",
                    ".#.#.#.##...#####.............#",
                    "......##..#.....##..#...####...",
                    "#.##..#.#....#..##.......###..#",
                    "..#.......##....#........#.##..",
                    "#.....#......#.....#....#..#...",
                    ".......##...#.....##.......#..#",
                    ".......#...#.#.#.........#####.",
                    "#.......#.##..##........##.....",
                    "##..#...#........##....#.......",
                    ".......#...##......##...##.##..",
                    "......#..##..#.#...#...#....##.",
                    "....#.#..#.....#.##.#.....#.#..",
                    "#..#.#.#........#...#.......##.",
                    "##...........#..#........#.....",
                    "....##....#....#.#.......#.....",
                    "....##.#.#.....#.#.....#.....#.",
                    "..........#.#..##..#..#.......#",
                    "#....#.......##...#...#.....#..",
                    ".........##.....#.#....#......#",
                    "..........#........#..#..#.#...",
                    "..#......#.....#......#......#.",
                    "..#...###..##..#.....##..#..##.",
                    "..#.#..###.........#.#...##.#.#",
                    "#.........#..#......#...##.....",
                    "...#...#.#..#...##.#...##.#..#.",
                    "#.....#.....#.##....#.#......#.",
                    "#....##..##..#.#..##....#.....#",
                    ".#..........#..#...#..#.......#",
                    "#.#.....#..##..##..#.#.........",
                    "....#..##...#.....#.....#.#.#.#",
                    "...#.#....#........#...#.#.....",
                    ".#............#.......#.##.#...",
                    "..##.......#.#...#........##..#",
                    "..................##.#...#.#..#",
                    ".#.........#.......#.....#.....",
                    "....##...##..#..........#......",
                    "..#.##..#....#..#............#.",
                    "....####...#.##....##.#....#.##",
                    "#..#....#......##........##....",
                    "..###...........##..#......#...",
                    "#..#.......#........#.......#..",
                    ".....#....#..#..##.....#.......",
                    ".###.####.#....#....#..#.......",
                    ".............#...............#.",
                    ".#..........#.#....#..#.#......",
                    "..............##....#..#....##.",
                    ".......#.#..#........#.......##",
                    "#..#...#..#.#........#..#....#.",
                    "...#.........#...#..#..........",
                    "...#....##...#..#..........#...",
                    ".#......#......##..##...#.#....",
                    ".#.........#..###..............",
                    ".................#.#.....##....",
                    "...#............#..............",
                    "#..#................#.......#..",
                    "...#.......#......#.#.#........",
                    "#.....#.##....#.....#........#.",
                    "......##.#....#........#....#..",
                    ".#..#.##...##........#.#.....#.",
                    "..#...#....#...#..#..##..#.#..#",
                    "#.................#.#.......##.",
                    "..........#........#.#.....#..#",
                    "#....##....#........##..##.#...",
                    "#...#....#.....#.....#.....#...",
                    "#..#..........#....##....#....#",
                    "..#.#..#..#....#.#....#....#..#",
                    "#....#..#.......#..........#...",
                    ".#...#.#...#..#...#.......#....",
                    "###........#......##..#...##...",
                    "...#..........##..............#",
                    ".......#........##......#.....#",
                    ".#..........#...#...##....###.#",
                    ".#...#....#..#.....##...#..##..",
                    ".#.#.#...##..........##...#...#",
                    ".#.....#...#........#........##",
                    "#.......#......##.#.#..#....#..",
                    "##..#.##........#....#..#......",
                    "...#.......................#...",
                    "..#....#..##........##.#.##.#..",
                    ".............#.......#....#.#.#",
                    "...#...........##..#.....#.....",
                    "..#....##....#.....#...........",
                    "..#.....#......#..#.###.##....#",
                    ".#.......#...........#...#....#",
                    "#............##...#...#.....#..",
                    "##...#.....#.........##...##...",
                    "...#...........#....##.........",
                    "#.##..#..........##..#......#..",
                    ".......#.#.......##.......#....",
                    "..#.....##..#...#.......#......",
                    ".#........#....##...........#..",
                    "#.......#...#.#.###...#....#...",
                    "..........##..#..#..##........#",
                    "#....#....#...#....#....#......",
                    "...........#....#...#...##.#...",
                    ".........#.#.....#.............",
                    "..####...........##..........#.",
                    ".....#...................#.....",
                    "#..##...#........#.###.#.##....",
                    "....##...#.##................#.",
                    ".#........###.#............#.#.",
                    "..............#.##.........#...",
                    "##............#.#..###....#...#",
                    "#.....#........####....#....##.",
                    "....##..#...##..##...##.....#..",
                    "##..#....#.##.....####.....#.##",
                    "##..#....#.##.##.#.#........#..",
                    "....#..........##.....#..#..#..",
                    "...#.......#........#.........#",
                    "#..##.######.......##........#.",
                    "###...#...####.......#.....#...",
                    "#......#..#.....#......#.....#.",
                    "..................##...#.......",
                    "....#.#....#......#...#.....##.",
                    "..#..#..#..#..#....#.#...#....#",
                    "......#....###.................",
                    "#.##......#...#......#.........",
                    "#..#.#...##..#.......#..#...#..",
                    ".#....#.#........#.........#...",
                    "#.......##..#..#...............",
                    "........#..##....#.....#..#....",
                    "....#......##..#....#...#..#...",
                    "#.....#...##..#...#......#.....",
                    ".....#.....#.........##...#..#.",
                    "........#...##.#...#.#....#..##",
                    "....#....#...#.....##..#...#...",
                    "#....#..#.........#.........###",
                    "..###.....##...#.#....##......#",
                    "#..#.#..#.......#..#....##.....",
                    "###...#.##..#.......#......#...",
                    ".....#.....##.......#...##..#..",
                    "......#.......#.#.#......#..#..",
                    ".................##..#.###.....",
                    "..........#....#...#..........#",
                    "...#.#...#.#..##.....#.#.##..#.",
                    ".......#..#....#...#......###..",
                    "...##..........#..#.....#....#.",
                    ".#..##..###...#....##.....#....",
                    "..#.#..............#....#...#..",
                    ".....####.......#.#.##....#....",
                    "#.#.#..##.##.#..#.##.#....#..#.",
                    "........#....#.......##........",
                    "...#...#....#...###.....###....",
                    ".....#..#..........##.#...##.##",
                    "..#.#.#..#....#...#..##...#...#",
                    "..#......#..#.#.....#....#....#",
                    ".#.....#.......#............#..",
                    "#..##....#...#....##....#......",
                    "#..#.........#...#...###.#..#..",
                    "..#.#.#..#.#..#.......##.......",
                    "...##...............#..#...#.#.",
                    ".......####.#.....#..#..#......",
                    "......#..#.....#..##....#......",
                    "....#...#.........##.......#.#.",
                    "#.#.#...#.....#...#..#.#..#....",
                    "........#..#.........#..#..##..",
                    "........###.#............#.#...",
                    "#..#.......#.#..#.......#...#.#",
                    "..##..............#.#.....#...#",
                    "..##...........................",
                    "..#.....#.......#......##......",
                    "#...#......##.#....#.#.#...##.#",
                    "#...#.#......#.#..##.........#.",
                    ".##..#...#.#.....#.#.#...#.#..#",
                    ".#..#...#.#.........#......#...",
                    "...........#...#...#...#..#.#..",
                    ".#........#...#......##...#.###",
                    "#........#..#.#..#...........##",
                    ".#...#...####.......#..........",
                    "......#...............#........",
                    ".....#.#.....#.#...#......#....",
                    ".#........#...........#..##.#..",
                    "....#..#.....###.......#...#...",
                    "#.#.........#...##..#.#.##.#...",
                    "................##.#....#.#...#",
                    ".......#.......#......#...#....",
                    "#....#.#..............#.##..###",
                    "..##.##..#.....#............#..",
                    "#....#..##........#....#.......",
                    ".#.#........#.#................",
                    "......##..#..#..........#..#.#.",
                    ".....##.#..#....##.#......##...",
                    "........###.#................#.",
                    "#..###.....#.###.#...#.#.......",
                    ".#..#.#.#.#..#..#.#.....#.#....",
                    "#....#.....#..#......##...#..##",
                    "........#...##..#.#.....#....#.",
                    ".......#..#..#..#....#.....##..",
                    "....#..##..#...#....#.........#",
                    "#.#....#..#.#...#.#...#....#...",
                    ".....#......###.......#..##.#.#",
                    ".......##.....#....#........#.#",
                    ".##.##..#..###.#....#.#.....#..",
                    "..##.#.......###.........#.....",
                    ".#...#......#..#....#..........",
                    ".....#........#.....##...#.....",
                    "..#......#.#.#..#.#....##.#...#",
                    "#.#...#...........##......#....",
                    ".................##.....#.#.##.",
                    "###..#....#..................#.",
                    "##..#.#.#...#....###.#.#...##.#",
                    "#.#.#..#....#..............#...",
                    ".....#....#......#..#.##.......",
                    "#...#...#..###.......#.......#.",
                    ".....#.#........#..#...#.#.....",
                    ".....#..........#.###.......#..",
                    "...#.##.....#....###.....#.....",
                    "####........#....#..#.#.##.#...",
                    "#......#...##.....#.#..##.#.#.#",
                    ".....##....#..#.........##.....",
                    "..##....##................##..#",
                    "#.....#...##...##.#.....#...#..",
                    "..#..#.#.#....#.#.......#......",
                    "##.....##......#...#.........#.",
                    "#..........#........#.#......#.",
                    ".#..#.......#.#.....#..........",
                    ".........#.#.......#.#..#..#..#",
                    "#......#....#....#..##..##...##",
                    ".....#..#...#.......#.....##...",
                    "..#.##........#.###...#...#...#",
                    "..#..#...........#..........#..",
                    ".#.#.#...#.##.#..............#.",
                    "....#..##.......#.....#..##..#.",
                    ".#.##.#....##........#...##.##.",
                    "...#.#...#....#....#......#####",
                    ".....#.....##...........#......",
                    "#........#.##.......#.#.......#",
                    "#...#.......##.#.......#..#.#..",
                    "#...##..#....#............#.#..",
                    "........#.#..#...#..#...##..##.",
                    "#...#....#............#........",
                    "#.#.#.#.#....##.....##.........",
                    "......##.........#.......#.#..#",
                    "...#.#....#........#...........",
                    "...#.#.......#.....#...........",
                    "##....####......##.##..#.......",
                    "#......#...#..#.#..#......#..#.",
                    "#......#.#....#....#..#........",
                    "..#.###...#.....#........#.#...",
                    "..#.....##.....###....#.....#..",
                    "#.##.#.....##....#...###.......",
                    "###.#....###.#..##.#.......##.#",
                    "#..#..##...#.#..........##.##..",
                    ".......####.#..#.....##..###...",
                    "#...#...##..#..##.......###....",
                    "#....#.........##..#.........#.",
                    ".....#.#..........#..#...#.#..#",
                    "..........#......##..#..#.#....",
                    ".#...#...#...#........###....##",
                    "#....#.##..........#.#.....#.#.",
                    "#....##.#.##..#.......#.#.....#",
                    ".##..##..#.#...#.#...........#.",
                    "....##..#...#.#.##.#.#...#.....",
                    ".#...#.##........#.##..#.#....#",
                    ".#.....##.........#.....#......",
                    "..#.....#.#..#.##.............#",
                    "##....##...#....##........#....",
                    ".#....#........#.#..#..#..#.##.",
                    ".#........#............#.......",
                    ".#..##..##..#..#..####....#....",
                    "..#.###....#..#.##......#.#...#",
                    ".###..#.#...##....##....#..##.#",
                    "....##........#....#.#.#...##..",
                    "...#..#....#.#....#...#.#.....#",
                    "...##....##..#....#.........#..",
                    ".....#..##.###..#.....####.....",
                    "...#..#.........#....#.#.##..#.",
                    "...#..#...............#..#....#",
                    "...........#.....#...####..##.#",
                    "..#......#...#....#..#...##.#..",
                    ".....#..#...........#.......#.#",
                    "##....###...#.........#....#...",
                    "...#..##.......#.#.....##....#.",
                    "#.#...#.#....#.....#...##.....#",
                    ".#...##....#.....#..##.......#.",
                    "...#........##..........#.....#",
                    "#...##..#.#....###...#..#......",
                    "............#.......#......#.#.",
                    "......#....#.#...#...#..#......",
                    ".#..#......#....#.......#....##",
                    "...#...#.......###..###...#....",
                    ".............#.#...#..###.....#",
                    ".#.....#........#...##....#..#.",
                    ".....#.......#######.#.#...#..."
            };

            return lst;
        }

        /// <summary>
        /// Add more charecters on the right of the tree
        /// </summary>
        /// <param name="lst">List of string</param>
        internal static void ExtendList(List<string> lst)
        {
            List<string> mainLst = GetPuzzleInput();
            for (int i = 0; i < lst.Count; i++)
            {
                lst[i] = String.Concat(lst[i], mainLst[i]);
            }
        }
    }
}