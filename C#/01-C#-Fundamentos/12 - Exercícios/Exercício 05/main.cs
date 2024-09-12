using System;

class HelloWorld
{
  static void Main()
  {
      string pangram = "The quick brown fox jumps over the lazy dog";
      string[] pangramStringArray = pangram.Split(" ");
      int i = 0;
      
      foreach (string word in pangramStringArray)
      {
          char[] charArray = word.ToCharArray();
          Array.Reverse(charArray);
          
          string reversedWord = "";
          foreach (char character in charArray)
          {
              reversedWord = reversedWord + character; 
          }
          
          pangramStringArray[i] = reversedWord;
          i++;
      }
      
      string newPangram = String.Join(" ", pangramStringArray);
      Console.WriteLine(newPangram);
  }
}