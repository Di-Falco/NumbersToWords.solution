using System.Collections.Generic;

namespace NumbersToWords
{
  public class NumWords
  {
    public string Number {get; set; }
    //public string Word {get; }
    private Dictionary<char, string> Ones = new Dictionary<char, string>{{'1', "one"}, {'2', "two"}, {'3', "three"}, {'4', "four"}, {'5', "five"}, {'6', "six"}, {'7', "seven"}, {'8', "eight"}, {'9', "nine"}, {'0', ""}};
    private Dictionary<char, string> Tens = new Dictionary<char, string>{{'1', "ten"}, {'2', "twenty"}, {'3', "thirty"}, {'4', "forty"}, {'5', "fifty"}, {'6', "sixty"}, {'7', "seventy"}, {'8', "eighty"}, {'9', "ninety"}};
    private Dictionary<char, string> Teens = new Dictionary<char, string>{{'1', "eleven"}, {'2', "twelve"}, {'3', "thirteen"}, {'4', "fourteen"}, {'5', "fifteen"}, {'6', "sixteen"}, {'7', "seventeen"}, {'8', "eighteen"}, {'9', "nineteen"}};
    private Dictionary<int, string> Places = new Dictionary<int, string>{ {2, "-hundred"}, {3, "-thousand"}, {4, "-thousand"}, {5, "-hundred thousand"}, {6, "-million"}, {7, "-million"}, {8, "-hundred million"}, {9, "-billion"}, {10, "-billion"}, {11, "-hundred billion"}, {12, "-trillion"}};
    
    public NumWords(string number)
    {
      Number = number;
    }

    public string WordNumber(string number)
    {
      string word = "";
      if (number == "0")
      {
        word += "zero";
      } else {
        char[] charNumber = number.ToCharArray();
        for (int i=0; i<charNumber.Length; i++) {
          if (i == charNumber.Length-2 && charNumber.Length >= 2 && charNumber[charNumber.Length - 2] == '1' && charNumber[charNumber.Length-1] != '0')
          {
            word += Teens[charNumber[charNumber.Length-1]];
            break;
          } else if (i == charNumber.Length-1) {
            word += Ones[charNumber[i]];
          } else if (i == charNumber.Length-2) {
            word += Tens[charNumber[i]];
          } else {
            word += Ones[charNumber[i]] + Places[charNumber.Length-1-i];
          }
          word += " ";
        }
      }
      return word;
    }
  }
}