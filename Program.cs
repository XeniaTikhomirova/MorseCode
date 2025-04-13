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
    
    //Division for words:
    string[] words = morseCode.Split(new string[] { "   " }, StringSplitOptions.None);
    
    //Place for saving decorded words:
    List<string> decordedWords = new List<string>();
    
    //split sentence in words:
    foreach(string word in words) {
      
      //split each word in letters:
      string[] letters = word.Split(' ');
      Console.WriteLine(word);
      
      //place for saving decorded letters:
      string decodedWord = "";

      //Decord each letter if its exist and not a null, then add to saving space decodedWord:
      
      foreach (string letter in letters) {
        if(!string.IsNullOrEmpty(letter)) {
          decodedWord += MorseCode.Get(letter);          
        }
        Console.WriteLine(decodedWord);
      }

      //Collect all words together:         
      decordedWords.Add(decodedWord);         
    }

    //Separate words with "space":
    
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

