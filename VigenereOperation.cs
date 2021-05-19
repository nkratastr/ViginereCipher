using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViginereCipher
{
    public class VigenereOperation
    {
        public string plainText;
        public string plainTextLetters;
        public string CipherTextVigenere;
        public string secretKey;
        public int cipherOrDecipher = 1;
        public int decipherAlphabetDecreaser = 0;

        public string alphabetToCipher = "abcçdefgğhıijklmnoöprsştuüvyzabcçdefgğhıijklmnoöprsştuüvyz";

        public bool chiperWithSpace = false;
    }
}