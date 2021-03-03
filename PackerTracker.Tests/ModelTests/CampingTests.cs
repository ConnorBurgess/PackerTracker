using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;
using System;
using System.Collections.Generic;

namespace PackerTracker.Tests
{
  [TestClass]
  public class CampingTests
  {
    [TestMethod]
    public void Camping_CreatesInstanceOfCamping_True()
    {
      Camping newCamping = new Camping("test" , true);
      Assert.AreEqual(typeof(Camping), newCamping.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Chainsaw";
      bool packed = true;
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
      bool yes = true;
      bool no = false;
      Camping newItem01 = new Camping(item01, yes);
      Camping newItem02 = new Camping(item02, no);
      Camping newItem03 = new Camping(item03, yes);
      List<Camping> newList = new List<Camping> { newItem01, newItem02, newItem03 };
      List<Camping> result = Camping.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}

    // [TestMethod]
    // public void GetDescription_ReturnsDescription_String()
    // {
    //   //Arrange
    //   string description = "Walk the dog.";

    //   //Act
    //   Item newItem = new Item(description);
    //   string result = newItem.Description;

    //   //Assert
    //   Assert.AreEqual(description, result);
    // }