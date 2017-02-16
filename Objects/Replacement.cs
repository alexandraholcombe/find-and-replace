using System;
using System.Collections.Generic;

namespace FindAndReplace.Objects
{
  public class UserInput
  {
    private string _original;
    private string _word;
    private string _replacement;

    public UserInput(string original, string word, string replacement)
    {
      _original = original;
      _word = word;
      _replacement = replacement;
    }

    public string GetOriginal()
    {
      return _original;
    }
    public string GetWord()
    {
      return _word;
    }
    public string GetReplacement()
    {
      return _replacement;
    }

    public string FindAndReplace()
    {
      string originalInput = GetOriginal();
      string wordInput = GetWord();
      string replacementInput = GetReplacement();
      List<string> replacementList = new List<string>(){};
      string result;
      if (originalInput.Equals(wordInput))
      {
        return replacementInput;
      }
      else if (originalInput.ToLower().Contains(wordInput.ToLower()))
      {
        string[] originalSplit = originalInput.Split(' ');
        for (int i = 0; i < originalSplit.Length; i++)
        {
          if (originalSplit[i].ToLower().Equals(wordInput.ToLower()))
          {
            replacementList.Add(replacementInput);
          }
          else
          {
            replacementList.Add(originalSplit[i]);
          }
        }
        result = string.Join(" ", replacementList.ToArray());
        return result;
      }
      else
      {
        return originalInput;
      }

    }
  }
}
