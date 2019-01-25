/* Play20Q class - Plays a single game.
 * Handles situations where tree is null and where tree is a single (leaf) node.
 * These situations are not required for the student projects, but I left them in.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/* Xander Kaylan
 * This class plays a game, learns the new names and differences, and includes it in the next game.
 */

namespace _20_Questions
{
    class Play20Q
    {
        static Node currentBranchNode;
        // Play a complete round of the game, starting at the root of the tree
        // and working down to a leaf node.  If the program correctly guessed
        // the name, it wins.  If it didn't get the name correct, it learns
        // the name the player had in mind and grows the tree to include the
        // new name, the old name, and a new phrase that delineates them.

        public static void PlayR(BinTree tree, Node n) { //recursive method to do one game and multiple games -- I found a way to do the single game and the muliple games in one method!
            if (n.left != null) {
                currentBranchNode = n;
            }
            string userInput = "";
            Console.Write("Is it " );
            n.Display();
            userInput = Console.ReadLine();

            if (userInput == "y")
            {

                if (n.left != null) {
                    PlayR(tree, n.left); //using recursion to add the new names and differences. It recursively calls the method with the new inputs                                
                }
                else {
                    Console.WriteLine("Hurray! I win!");
                }
            } 
            else if (userInput == "n") {
               if (n.right != null) {
                    PlayR(tree, n.right); //using recursion to add the new names and differences. It recursively calls the method with the new inputs
                }
                else {
                        Console.WriteLine("Who were you thinking of?");
                        userInput = Console.ReadLine();
                        Console.WriteLine("What is the difference between " + n.Data + " and " + userInput + "?");
                        string diff = Console.ReadLine();
                        Console.WriteLine("I love learning new things!");
                        tree.Add(userInput, diff, n);
                    
                } 
            }
        }

    }
}
