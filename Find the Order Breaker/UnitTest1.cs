using System;
using NUnit.Framework;
using System.Collections.Generic;
using ConsoleApp1;

[TestFixture]
public class OrderBreakerTestExample
{

    List<(List<int>, int)> tests = new List<(List<int>, int)>() {
                  (new List<int>() { 2, 1 }, 2 ),
                  (new List<int>() { 0, -10 }, 0),
                  (new List<int>() { 15, 0 }, 15 ),
                  (new List<int>() { 1, 3, 2 }, 3 ),
                  (new List<int>() { 1, 0, 2 }, 1 ),
                  (new List<int>() { 1, 2, 0, 3, 4 }, 0 ),
                  (new List<int>() { 1, 2, 3, 4, -1 }, -1 ),
                  (new List<int>() { -11, 5, 0, 3, 4 }, 5 ),
                  (new List<int>() { -11, -5, 0, -2, 4 }, 0 ),
                  (new List<int>() { 5, 7, 6, 8, 9, 10 }, 7 ),
                  (new List<int>() { 1, 2, 3, 4, 17, 5, 6, 7, 8 }, 17 ),
                  (new List<int>() { 19, 27, 33, 34, 112, 578, 116, 170, 800 }, 578 ),
                  (new List<int>() { 105, 110, 111, 112, 114, 113, 115 }, 114 ),
                  (new List<int>() { 1001, 991, 992, 993, 994, 995, 996 }, 1001 ),
            };

    [Test]
    public void test1()
    {
        Assert.AreEqual(tests[0].Item2, Kata.OrderBreaker(tests[0].Item1.ToArray()));
        Assert.AreEqual(tests[1].Item2, Kata.OrderBreaker(tests[1].Item1.ToArray()));
        Assert.AreEqual(tests[2].Item2, Kata.OrderBreaker(tests[2].Item1.ToArray()));
        Assert.AreEqual(tests[3].Item2, Kata.OrderBreaker(tests[3].Item1.ToArray()));
        Assert.AreEqual(tests[4].Item2, Kata.OrderBreaker(tests[4].Item1.ToArray()));
        Assert.AreEqual(tests[5].Item2, Kata.OrderBreaker(tests[5].Item1.ToArray()));
        Assert.AreEqual(tests[6].Item2, Kata.OrderBreaker(tests[6].Item1.ToArray()));
        Assert.AreEqual(tests[7].Item2, Kata.OrderBreaker(tests[7].Item1.ToArray()));
        Assert.AreEqual(tests[8].Item2, Kata.OrderBreaker(tests[8].Item1.ToArray()));
        Assert.AreEqual(tests[9].Item2, Kata.OrderBreaker(tests[9].Item1.ToArray()));
        //foreach (var test in tests)
        //{
        //    Assert.AreEqual(test.Item2, Kata.OrderBreaker(test.Item1.ToArray()));
        //}
    }
}