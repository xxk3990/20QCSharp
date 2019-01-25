using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/* Xander Kaylan
 * This class creates the left and right nodes, gives them properties, and creates the data node and its property.
 */
namespace _20_Questions
{
    public class Node
    {
        public string data;
        public Node left;
        public Node right;
        public Node Left
        {
            get
            {
                return this.left;
            }
            set
            {
                this.left = value;
            }
        }
        public Node Right
        {
            get
            {
                return this.right;
            }
        }

        public string Data
        {
            get
            {
                return data;
            } set {
                data = value;
            }
        }
        public Node(string data)
        {

            this.data = data;
        }
        public void Display()
        {

            Console.WriteLine(data + "?"); //added question mark so it asks in the form of a question!!
        }
    }
}
