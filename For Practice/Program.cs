using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace For_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "Walter White";
            string cryptoName = "";
            for (int i = 0; i < name.Length; i++)
            {
                char cryptoChar = (char)((int)name[i] + 1);
                cryptoName = cryptoName + cryptoChar;
                Console.Write(cryptoChar + " ");


            }
            Console.WriteLine();
            for (int i = 0; i < cryptoName.Length; i++)
            {
                char cryptoChar = (char)((int)cryptoName[i] - 1);

                Console.Write(cryptoChar + " ");
            }




        }
        
    }
}
