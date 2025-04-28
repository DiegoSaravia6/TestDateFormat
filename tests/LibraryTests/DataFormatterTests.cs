namespace LibraryTests;
using NUnit.Framework;
using System;
using Ucu.Poo.TestDateFormat;


public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestRightFormat()
    {
        string testDate = "12/11/1999";
        string expectedResult =  "1999-11-12";
        string result = DateFormatter.ChangeFormat(testDate) ;
        
        Assert.That(result == expectedResult,$"expected: {expectedResult} \n    result: {result}");
    }
    [Test]
    public void TestWrongFormat()
    {
        string testDate = "12/11199";
        string expectedResult = "Error: Wrong format";
        string result = DateFormatter.ChangeFormat(testDate) ;
        
        Assert.That(result == expectedResult,$"expected: {expectedResult} \n    result: {result}");
    }
    [Test]
    public void TestBlancDate()
    {
        string testDate = "";
        string expectedResult = "Error: Blanc date";
        string result = DateFormatter.ChangeFormat(testDate) ;
        
        Assert.That(result == expectedResult,$"expected: {expectedResult} \n    result: {result}");
    }

}