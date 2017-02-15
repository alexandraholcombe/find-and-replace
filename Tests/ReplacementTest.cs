using Xunit;
using FindAndReplace.Objects;
using System;
using System.Collections.Generic;

namespace FindAndReplace
{
  public class UserInputTest
  {
    [Fact]
    public void FindAndReplace_NoMatch_original()
    {
      string original = "Hello World";
      string word = "phone";
      string replacement = "bananas";

      UserInput testUserInput = new UserInput(original, word, replacement);
      string output = testUserInput.FindAndReplace(testUserInput);
      string expectedOutput = original;
      Assert.Equal(expectedOutput, output);
    }
  }
}
