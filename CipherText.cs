using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViginereCipher
{
    public class CipherText
    {
        public VigenereOperation CipherGivenText(VigenereOperation vigenereOperation)
        {
            int mode = 0;
            int[] secretKeyNumberToMode = SecretKeyLetterToLetterNumbers(vigenereOperation);

            foreach (var character in vigenereOperation.plainText)
            {
                if (char.IsLetter(Convert.ToChar(character)))
                {
                    vigenereOperation.plainTextLetters = vigenereOperation.plainTextLetters + character;
                }
            }

            for (int i = 0; i < vigenereOperation.plainTextLetters.Length; i++)
            {
                for (int k = 0; k < 29; k++)
                {
                    if (vigenereOperation.alphabetToCipher[k + vigenereOperation.decipherAlphabetDecreaser] == vigenereOperation.plainTextLetters[i])
                    {
                        mode = (i) % (vigenereOperation.secretKey.Length);

                        vigenereOperation.CipherTextVigenere += vigenereOperation.alphabetToCipher[k + vigenereOperation.decipherAlphabetDecreaser + (vigenereOperation.cipherOrDecipher * (secretKeyNumberToMode[mode] + 1))];
                    }
                }
            }

            return vigenereOperation;
        }

        public int[] SecretKeyLetterToLetterNumbers(VigenereOperation vigenereOperation)
        {
            var secretKeyCharArray = vigenereOperation.secretKey.ToCharArray();
            int[] secretKeyLetterNumber = new int[secretKeyCharArray.Length];
            for (int k = 0; k < secretKeyCharArray.Length; k++)
            {
                for (int i = 0; i < 29; i++)
                {
                    if (secretKeyCharArray[k] == vigenereOperation.alphabetToCipher[i])
                    {
                        secretKeyLetterNumber[k] = i;
                    }
                }
            }

            return secretKeyLetterNumber;
        }
    }
}