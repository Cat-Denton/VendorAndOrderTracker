using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorAndOrderTracker.Models;
using System;

namespace VendorAndOrderTracker.Tests
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
      Vendor newVendor = new Vendor("testName","testDescript");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      Vendor newVendor = new Vendor("testName","testDescript");
      string name = "testName";
      string result = newVendor.Name;
      Assert.AreEqual(result,name);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      Vendor newVendor = new Vendor("testName","testDescript");
      string description = "testDescript";
      string result = newVendor.Description;
      Assert.AreEqual(result,description);
    }

    [TestMethod]
    public void SetName_SetName_String()
    {
      Vendor newVendor = new Vendor("testName","testDescript");
      string updatedName = "updatedName";
      newVendor.Name = updatedName;
      string result = newVendor.Name;
      Assert.AreEqual(result,updatedName);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      Vendor newVendor = new Vendor("testName","testDescript");
      string updatedDescript = "updatedDescript";
      newVendor.Description = updatedDescript;
      string result = newVendor.Description;
      Assert.AreEqual(result,updatedDescript);
    }
  }
}
