using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker.Models;
using System.Collections.Generic;
using System;

namespace Tracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor", "Oct 01, 2023");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsNameOfVendor_String()
    {
      string name = "Test Vendor";
      string date = "Oct 01, 2023";
      Vendor newVendor = new Vendor(name, date);

      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      string date = "Oct 01, 2023";
      Vendor newVendor = new Vendor(name, date);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string vendor01 = "Suzie's Cafe";
      string vendor02 = "PDX Brunch";
      string date = "Oct 01, 2023";

      Vendor newVendor1 = new Vendor(vendor01, date);
      Vendor newVendor2 = new Vendor(vendor02, date);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string vendor01 = "Suzie's Cafe";
      string vendor02 = "PDX Brunch";
      string date = "Oct 01, 2023";

      Vendor newVendor1 = new Vendor(vendor01, date);
      Vendor newVendor2 = new Vendor(vendor02, date);

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void GetDate_ReturnsRegisterDate_String()
    {
      string name = "PDX Brunch";
      string date = "Oct 01, 2023";

      Vendor newVendor = new Vendor(name, date);

      string result = newVendor.Date;

      Assert.AreEqual(date, result);
    }
  }
}