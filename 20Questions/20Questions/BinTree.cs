using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/* Xander Kaylan 
 * This class is where I read from the file, build from the file and add to it, and save to it.
 */
namespace _20_Questions
{
    public class BinTree
    {
        StreamReader reader = new StreamReader("20questions.txt"); 

        public Node root;
        public Node Root {
            get {
                return root;
            } set {
                root = value;
            }
        }
        public BinTree()
        {
            root = null;
        }
        //public void HardCode() {

        //        root = new Node("Are they alive?");
        //        root.left = new Node("Is it Roger Waters?");
        //        root.right = new Node("Is it Jimi Hendrix?");
        //        root.left.left = new Node("y");
        //        root.left.right = new Node("n");
        //        root.right.left = new Node("y");
        //        root.right.right = new Node("n");

        //}

        public void ReadTree() {

            string line = null;
            Console.WriteLine(line);

            root = BuildNodeFromFile();
            reader.Close();
        }
        Node BuildNodeFromFile() {

            Node newNode = null;
            string lineFromFile = reader.ReadLine();

            char nodeType = lineFromFile[0];

            lineFromFile = lineFromFile.Remove(0, 1);
            newNode = new Node(lineFromFile);



            if (nodeType == 'B')
            {
                newNode.left = BuildNodeFromFile();
                newNode.right = BuildNodeFromFile();

            }

            return newNode;
        }

        public void Add(string newName, string newDiff, Node curNode) {
            //curNode = current node
            curNode.left = new Node(newName);
            curNode.right = new Node(curNode.Data);
            curNode.Data = newDiff;
        }
        public void SaveTree()
        {
            StreamWriter write = new StreamWriter("20questions.txt");
            if (root != null)
            {
               SaveNode(root, write);
            }
            write.Close();
        }
         public void SaveNode(Node n, StreamWriter writer) //adds to file when game ends!
        {
            if (n.left != null)
            {
                writer.WriteLine("B" + n.data);
            }
            if (n.right == null) {
                writer.WriteLine("L" + n.data);
            }
            if (n.left != null)
            {
                SaveNode(n.left, writer);
            }

            if (n.right != null)
            {
               SaveNode(n.right, writer);
            }



        }

    }
}
