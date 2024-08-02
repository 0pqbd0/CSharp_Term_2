using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassicList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ClassicListTests;

[TestClass()]
public class ListTest
{
    List list;

    [TestInitialize]
    public void Initialize()
    {
        list = new List();
    }

    [TestMethod()]
    public void AddTest()
    {
        list.Add(1);
        Assert.AreEqual(list.Size, 1);
    }

    [TestMethod()]
    public void RemoveTestWithoutException()
    {
        list.Add(1);
        list.Remove();
        Assert.AreEqual(list.Size, 0);
    }

    [TestMethod()]
    public void RemoveTestWithException()
    {
        var ex = Assert.ThrowsException<InvalidOperationException>(() => list.Remove());
        Assert.AreEqual(ex.Message, "List is empty");
    }

    [TestMethod()]
    public void ReplaceTestWithException()
    {
        list.Add(1);
        var ex = Assert.ThrowsException<IndexOutOfRangeException>(() => list.Replace(5, 15));
        Assert.AreEqual(ex.Message, "Invalid position value");
    }
}