using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;
using System;
using System.Collections.Generic;

namespace PackerTracker.Tests
{
  [TestClass]
  public class CampingTests : IDisposable
  {

    public void Dispose()
    {
      Camping.ClearAll();
    }

    [TestMethod]
    public void Camping_CreatesInstanceOfCamping_True()
    {
      Camping newCamping = new Camping("test" , "yes");
      Assert.AreEqual(typeof(Camping), newCamping.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Chainsaw";
      string packed = "yes";
      Camping newCamping = new Camping(name, packed);
      string result = newCamping.Name;
      
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetAll_ReturnsCamping_CampingList()
    {
      string item01 = "Chainsaw";
      string item02 = "Hatchet";
      string item03 = "Water";
      string packed = "yes";
      Camping newItem01 = new Camping(item01, packed);
      Camping newItem02 = new Camping(item02, packed);
      Camping newItem03 = new Camping(item03, packed);
      List<Camping> newList = new List<Camping> { newItem01, newItem02, newItem03 };
      List<Camping> result = Camping.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_CampingInstantiatesWithAnIdAndGetterReturns_Int()
    {
      string item01 = "Chainsaw";
      string packed = "yes";
      Camping newItem = new Camping(item01, packed);
      int result = newItem.Id;
      Assert.AreEqual(1, result);
    }
  }
}

