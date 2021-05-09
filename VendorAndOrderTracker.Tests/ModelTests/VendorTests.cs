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

    [TestMethod]
    public void GetAll_ReturnsVendors_VendorList()
    {
      string name01 = "Pierre's";
      string description01 = "mouthwash studio";
      string name02 = "Nancy's";
      string description02 = "pet bird skydiving";
      Vendor newVendor1 = new Vendor(name01,description01);
      Vendor newVendor2 = new Vendor(name02,description02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "jim";
      string description01 = "hunter";
      string name02 = "suzie";
      string descripton02 = "fisher";
      Vendor newVendor1 = new Vendor(name01,description01);
      Vendor newVendor2 = new Vendor(name02,descripton02);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2,result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string title = "puppies";
      string description = "8 great danes";
      int price = 20;
      string date = "july 4";
      Order newOrder = new Order(title,description,price,date);
      List<Order> newList = new List<Order> {newOrder};
      string name = "Jim's dogs";
      string vendorDescript = "dog breeder";
      Vendor newVendor = new Vendor(name,vendorDescript);
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList,result);
    }
  }
}
