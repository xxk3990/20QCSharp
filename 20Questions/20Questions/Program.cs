/* 20 Questions Game
 * Implements classic 20 questions binary decision tree with learning.
 */
//Part 1: 
//a. Set up a hardwired tree
//b. Play a single game without learning new names: answer yes to the name question(a leaf node)
//c. Play multiple games
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            BinTree tqTree = new BinTree();
            //tqTree.HardCode();              // Used before ReadTree() worked
            tqTree.ReadTree();

            string answer;
            Console.WriteLine("Welcome to 20 questions!  I'll try to guess your person.");

            do
            {
                Console.WriteLine();

                Play20Q.PlayR(tqTree, tqTree.root); //got this to work for both a single game and multiple games

                Console.Write("\nHow about another game? ");
                answer = Console.ReadLine();

            } while (answer.Equals("y"));

           tqTree.SaveTree();
            Console.WriteLine("Bye Bye!");
        }
    }
}

