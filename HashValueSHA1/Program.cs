using System;
using System.Security.Cryptography;
using System.Text;

/* Question
 * You have the following code.
 * string MessageString = “This is the original message!”;
 * You need to store the SHA1 hash value of MessageString in a variable named HashValue.
 * Which code should you use? Develop the solution by selecting and arranging the required code blocks in the correct order.
 * You may not need all of the code blocks.
 */

namespace HashValueSHA1
{
    class Program
    {
        static void Main(string[] args)
        {
            string MessageString = "This is the original message!";

            UnicodeEncoding unicode = new UnicodeEncoding();
            byte[] messageBytes = unicode.GetBytes(MessageString);

            SHA1Managed shHash = new SHA1Managed();
            byte[] hashValue = shHash.ComputeHash(messageBytes);
        }
    }
}
