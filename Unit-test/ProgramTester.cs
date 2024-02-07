using System;
using System.Collections.Generic;
using System.Text;

namespace Unittest
{
    public class ProgramTester
    {
        public static string KrypteraMorse(string text)
        {
            text = text.ToUpper(); 

            var morseAlphabet = new Dictionary<char, string>
            {
                {'A', ".-"},
                {'B', "-..."},
                {'C', "-.-."},
                {'D', "-.."},
                {'E', "."},
                {'F', "..-."},
                {'G', "--."},
                {'H', "...."},
                {'I', ".."},
                {'J', ".---"},
                {'K', "-.-"},
                {'L', ".-.."},
                {'M', "--"},
                {'N', "-."},
                {'O', "---"},
                {'P', ".--."},
                {'Q', "--.-"},
                {'R', ".-."},
                {'S', "..."},
                {'T', "-"},
                {'U', "..-"},
                {'V', "...-"},
                {'W', ".--"},
                {'X', "-..-"},
                {'Y', "-.--"},
                {'Z', "--.."}
            };

            var morseCode = new StringBuilder();

            foreach (char character in text)
            {
                if (morseAlphabet.ContainsKey(character))
                {
                    morseCode.Append(morseAlphabet[character]).Append(" ");
                }
                else if (character == ' ')
                {
                    morseCode.Append(" "); 
                }
                else
                {
                    morseCode.Append(" "); 
                }
            }

            return morseCode.ToString().Trim(); 
        }
    }
}
