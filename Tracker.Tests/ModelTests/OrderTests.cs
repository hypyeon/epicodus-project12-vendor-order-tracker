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

    [TestMethod]
    public void GetAll_ReturnsAllOrderObjects_OrderList()
    {
      string order01 = "Pastries";
      string order02 = "Garlic Bread";
      string date = "Oct 01, 2023";
      string price = "70";

      Order newOrder1 = new Order(order01, date, price);
      Order newOrder2 = new Order(order02, date, price);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string order01 = "Pastries";
      string order02 = "Garlic Bread";
      string date = "Oct 01, 2023";
      string price = "70";

      Order newOrder1 = new Order(order01, date, price);
      Order newOrder2 = new Order(order02, date, price);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }

  }
}