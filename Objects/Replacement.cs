using System;

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

    public string FindAndReplace(UserInput userInput)
    {
      string originalInput = GetOriginal();
      string wordInput = GetWord();
      string replacementInput = GetReplacement();

      return originalInput;
    }
  }
}
