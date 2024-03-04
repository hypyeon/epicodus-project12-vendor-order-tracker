using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker.Models;
using System.Collections.Generic;
using System;

namespace Tracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Pastries", "Oct 01, 2023", "92");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsNameOfProductBeingOrdered_String()
    {
      string name = "Pastries";
      string date = "Oct 01, 2023";
      string price = "92";
      Order newOrder = new Order(name, date, price);

      string result = newOrder.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      string name = "Pastries";
      string date = "Oct 01, 2023";
      string price = "92";
      Order newOrder = new Order(name, date, price);

      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetDate_ReturnsOrderDate_String()
    {
      string name = "Pastries";
      string date = "Oct 01, 2023";
      string price = "92";
      Order newOrder = new Order(name, date, price);

      string result = newOrder.Date;

      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPriceOfOrder_String()
    {
      string name = "Pastries";
      string date = "Oct 01, 2023";
      string price = "92";
      Order newOrder = new Order(name, date, price);

      string result = newOrder.Price;

      Assert.AreEqual(price, result);
    }
  }
}