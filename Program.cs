using System;
using System.Collections.Generic;

static class MorseCode
{
    private static readonly Dictionary<string, string> morseMap = new Dictionary<string, string>
    {
        { ".-", "A" },   { "-...", "B" }, { "-.-.", "C" }, { "-..", "D" },
        { ".", "E" },    { "..-.", "F" }, { "--.", "G" },  { "....", "H" },
        { "..", "I" },   { ".---", "J" }, { "-.-", "K" },  { ".-..", "L" },
        { "--", "M" },   { "-.", "N" },   { "---", "O" },  { ".--.", "P" },
        { "--.-", "Q" }, { ".-.", "R" },  { "...", "S" },  { "-", "T" },
        { "..-", "U" },  { "...-", "V" }, { ".--", "W" },  { "-..-", "X" },
        { "-.--", "Y" }, { "--..", "Z" }, { "-----", "0" },{ ".----", "1" },
        { "..---", "2" },{ "...--", "3" },{ "....-", "4" },{ ".....", "5" },
        { "-....", "6" },{ "--...", "7" },{ "---..", "8" },{ "----.", "9" }
    };

    public static string Get(string code)
    {
        return morseMap.ContainsKey(code) ? morseMap[code] : "?";
    }
}


class MorseCodeDecoder

{
	public static string Decode(string morseCode)
    
	{
    morseCode = morseCode.Trim();
    
    string[] words = morseCode.Split(new string[] { "   " }, StringSplitOptions.None);
    
    List<string> decordedWords = new List<string>();
    
    
    foreach(string word in words) {
      
      string[] letters = word.Split(' ');
      Console.WriteLine(word);
      
      string decodedWord = "";
      
      foreach (string letter in letters) {
        if(!string.IsNullOrEmpty(letter)) {
          decodedWord += MorseCode.Get(letter);          
        }
        Console.WriteLine(decodedWord);
      }         
      decordedWords.Add(decodedWord);         
    }
    
    return string.Join(" ", decordedWords);
		
	}

}


class Program {

   static void Main() {
      string morseCode = "... --- ...";
      string result = MorseCodeDecoder.Decode(morseCode);
      Console.WriteLine(result);

   }

}

