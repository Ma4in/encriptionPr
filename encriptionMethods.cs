using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encriptionPr
{
    internal class encriptionMethods
    {
        private static string alphabetEng { get; } = "abcdefghijklmnopqrstuvwxyz";
        private static string alphabetRUS { get; } = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        public static string podstanovka(string Message, string cWord, int langCode)
        {
            cWord = cWord.ToLower();
            Message = Message.ToLower();
            string alphabet = "";
            if (langCode == 1) { alphabet = alphabetRUS; }
            else { alphabet = alphabetEng; }

            string oAlphabet = alphabet;

            foreach (char c in cWord)
            {
                alphabet = alphabet.Replace(c.ToString(), "");
            }

            string encodedAlphabet = cWord + alphabet;

            Dictionary<char, char> encDict = new Dictionary<char, char>();

            for (int i = 0; i < oAlphabet.Length; i++)
            {
                encDict.Add(encodedAlphabet[i], oAlphabet[i]);
            }

            string encodedMassage = "";

            foreach (char c in Message)
            {
                encodedMassage += encDict[c];
            }

            return encodedMassage;
        }

        public static string decriptPodstanovka(string Message, string cWord, int langCode)
        {
            cWord = cWord.ToLower();
            Message = Message.ToLower();
            string alphabet = "";
            if (langCode == 1) { alphabet = alphabetRUS; }
            else { alphabet = alphabetEng; }

            string oAlphabet = alphabet;

            foreach (char c in cWord)
            {
                alphabet = alphabet.Replace(c.ToString(), "");
            }

            string encodedAlphabet = cWord + alphabet;

            Dictionary<char, char> encDict = new Dictionary<char, char>();

            for (int i = 0; i < oAlphabet.Length; i++)
            {
                encDict.Add(oAlphabet[i], encodedAlphabet[i]);
            }

            string encodedMassage = "";

            foreach (char c in Message)
            {
                encodedMassage += encDict[c];
            }

            return encodedMassage;
        }
    
        public static string perestanovka(string Message)
        {
            string encodedMassage = "";

            char[] row = new char[(Message.Length / 5 + 1) * 5];

            for (int i = 0; i < Message.Length; i++)
            {
                row[i] = Message[i];
            }

            char[][] matrix = new char[Message.Length / 5 + 1][];

            int k = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new char[] { row[k], row[k+1], row[k+2], row[k+3], row[k+4]};
                k += 5;
            };

            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    encodedMassage += matrix[i][j];
                }
            };
            encodedMassage = encodedMassage.Replace('\0', ' ');

            return encodedMassage;
        }

        public static string decriptPerestanovka(string Message)
        {
            string decriptedMessege = "";

            char[][] matrix = new char[Message.Length / 5 + 1][];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new char[5];
            }

            while (Message.Length % 5 != 0) Message += " ";

            int k = 0;
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    matrix[i][j] = Message[k];
                    k += 1;
                }
            };

            for (int j = 0; j < matrix.Length; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    decriptedMessege += matrix[j][i];
                }
            };

            return decriptedMessege;
        }
    
        public static string podmena(string Message, int langCode) 
        {
            string encryptMessage = "";
            string alphabet = "";
            if (langCode == 1) { alphabet = alphabetRUS; }
            else { alphabet = alphabetEng; }

            string encodedAlphabet = "";

            for (int i = alphabet.Length - 1; i > -1; i--)
            {
                encodedAlphabet += alphabet[i];
            }

            Dictionary<char, char> encDict = new Dictionary<char, char>();

            for (int i = 0; i < alphabet.Length; i++)
            {
                encDict.Add(alphabet[i], encodedAlphabet[i]);
            }


            foreach (char c in Message)
            {
                encryptMessage += encDict[c];
            }

            return encryptMessage;
        }

        public static string dePodmena(string Message, int langCode)
        {
            string encryptMessage = "";
            string alphabet = "";
            if (langCode == 1) { alphabet = alphabetRUS; }
            else { alphabet = alphabetEng; }

            string encodedAlphabet = "";

            for (int i = alphabet.Length - 1; i > -1; i--)
            {
                encodedAlphabet += alphabet[i];
            }

            Dictionary<char, char> encDict = new Dictionary<char, char>();

            for (int i = 0; i < alphabet.Length; i++)
            {
                encDict.Add(encodedAlphabet[i], alphabet[i]);
            }


            foreach (char c in Message)
            {
                encryptMessage += encDict[c];
            }

            return encryptMessage;
        }
    
        public static string gammirovanie(string Message, string cWord)
        {
            int[] encryptedMass = new int[Message.Length];
            string ans = "";

            for (int i = 0; i < Message.Length; i++)
            {
                encryptedMass[i] = Message[i] ^ cWord[i%cWord.Length];
                ans += encryptedMass[i].ToString() + "-";
            }
            return ans.Remove(ans.Length-1,1);
        }

        public static string deGammirovanie(string Message, string cWord)
        {
            string[] charsInts = Message.Split('-');
            char[] encryptedMass = new char[charsInts.Length];
            
            for (int i = 0; i < encryptedMass.Length; i++)
            {
                encryptedMass[i] = (char)(int.Parse(charsInts[i]));
            }
            string ans = "";

            for (int i = 0; i < encryptedMass.Length; i++)
            {
                ans += (char)(encryptedMass[i] ^ cWord[i % cWord.Length]);
            }
            return ans;
        }
    }
}
