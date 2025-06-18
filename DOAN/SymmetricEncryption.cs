using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN
{
    internal class SymmetricEncryption
    {
        static char[] character = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static string EncryptAddition(string plaintext, int key)
        {
            char[] charArray = plaintext.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                for (int j = 0; j < character.Length; j++)
                {
                    if (char.ToUpper(charArray[i]) == character[j])
                    {
                        int remainder = (j + key) % character.Length;
                        charArray[i] = character[remainder];
                        break;
                    }
                }
            }
            return new string(charArray);
        }

        public static string DecryptAddition(string ciphertext, int key)
        {
            char[] charArray = ciphertext.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                for (int j = 0; j < character.Length; j++)
                {
                    if (char.ToUpper(charArray[i]) == character[j])
                    {
                        int remainder = (j - key) % character.Length;
                        charArray[i] = character[remainder];
                        break;
                    }
                }
            }
            return new string(charArray);
        }

        public static string EncryptMultiplication(string plaintext, int key)
        {
            char[] charArray = plaintext.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                for (int j = 0; j < character.Length; j++)
                {
                    if (char.ToUpper(charArray[i]) == character[j])
                    {
                        int remainder = (j * key) % character.Length;
                        charArray[i] = character[remainder];
                        break;
                    }
                }
            }
            return new string(charArray);
        }

        public static string DecryptMultiplication(string ciphertext, int key)
        {
            char[] charArray = ciphertext.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                for (int j = 0; j < character.Length; j++)
                {
                    if (char.ToUpper(charArray[i]) == character[j])
                    {
                        int remainder = (j * (key ^ -1)) % character.Length;
                        charArray[i] = character[remainder];
                        break;
                    }
                }
            }
            return new string(charArray);
        }
    }
}
