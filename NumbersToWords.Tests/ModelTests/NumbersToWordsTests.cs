using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class NumWordsTests
  {
    [TestMethod]
    public void WordNumber_ReturnOne_string()
    {
      string number = "1";
      NumWords newNumWords = new NumWords(number);
      
      Assert.AreEqual("one ", newNumWords.WordNumber(number));
    }
    [TestMethod]
    public void WordNumber_ReturnTwoDigits_string()
    {
      string number = "23";
      NumWords newNumWords = new NumWords(number);

      Assert.AreEqual("twenty three ", newNumWords.WordNumber(number));
    }
    [TestMethod]
    public void WordNumber_ReturnTwoTeenDigits_string()
    {
      string number = "13";
      NumWords newNumWords = new NumWords(number);

      Assert.AreEqual("thirteen", newNumWords.WordNumber(number));
    }
    [TestMethod]
    public void WordNumber_ReturnThreeDigits_string()
    {
      string number = "123";
      NumWords newNumWords = new NumWords(number);

      Assert.AreEqual("one-hundred twenty three ", newNumWords.WordNumber(number));
    }
      [TestMethod]
    public void WordNumber_ReturnFourDigits_string()
    {
      string number = "1283";
      NumWords newNumWords = new NumWords(number);

      Assert.AreEqual("one-thousand two-hundred eighty three ", newNumWords.WordNumber(number));
    }
      [TestMethod]
    public void WordNumber_ReturnFourDigitsWithTeen_string()
    {
      string number = "1213";
      NumWords newNumWords = new NumWords(number);

      Assert.AreEqual("one-thousand two-hundred thirteen", newNumWords.WordNumber(number));
    }
  }
}