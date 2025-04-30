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
        string expectedResult = "1999-11-12";
        string result = DateFormatter.ChangeFormat(testDate) ;
        
        Assert.That(result == expectedResult,$"expected: {expectedResult} \n    result: {result}");
    }
    [Test]
    public void TestWrongFormat()
    {
        string testDate = "12/11199";
        string expectedResult = "Error: Invalid format";
        string result = DateFormatter.ChangeFormat(testDate) ;
        
        Assert.That(result == expectedResult,$"expected: {expectedResult} \n    result: {result}");
    }
    [Test]
    public void TestBlancDate()
    {
        string testDate = "";
        string expectedResult = "Error: Invalid date";
        string result = DateFormatter.ChangeFormat(testDate) ;
        
        Assert.That(result == expectedResult,$"expected: {expectedResult} \n    result: {result}");
    }
    [Test]
    public void TestDigit()
    {
        string testDate = "3A/10/2020";
        string expectedResult = "Error: Invalid date";
        string result = DateFormatter.ChangeFormat(testDate) ;
        
        Assert.That(result == expectedResult,$"expected: {expectedResult} \n    result: {result}");
    }

    [Test]
    public void TestDays()
    {
        string testDate = "50/12/2002";
        string expectedResult = "Error: Invalid day";
        string result = DateFormatter.ChangeFormat(testDate) ;
        
        Assert.That(result == expectedResult,$"expected: {expectedResult} \n    result: {result}");
    }

    [Test]
    public void TestMonths()
    {
        string testDate = "20/92/1902";
        string expectedResult = "Error: Invalid month";
        string result = DateFormatter.ChangeFormat(testDate) ;
        
        Assert.That(result == expectedResult,$"expected: {expectedResult} \n    result: {result}");
    }

    [Test]
    public void TestFebrero()
    {
        string testDate = "31/02/2002";
        string expectedResult = "Error: Invalid date";
        string result = DateFormatter.ChangeFormat(testDate) ;
        
        Assert.That(result == expectedResult,$"expected: {expectedResult} \n    result: {result}");
    }
}