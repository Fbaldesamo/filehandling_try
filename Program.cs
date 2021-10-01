using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace filehandling_try
{
    class Program
    {
        static void Main(string[] args)
        {
            //open/creat the file text
            FileStream fs = new FileStream("firstTry.txt", FileMode.Create);

            //enable you to write in the text
            StreamWriter sw = new StreamWriter(fs);

            //get the user input
            Console.Write("Input Your Name: ");
            string fName = Console.ReadLine();

            //will put/save the input in the file
            sw.WriteLine("FirstName: "+ fName);

            //will close the file 
            sw.Close();
            fs.Close();



            Console.WriteLine("Press key to exit");

            Console.ReadKey();
            

        }
    }
}
