using DonationWebApp.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTests
{
    public class GoodsTests
    {
        GoodsClass goodsClass;

        [SetUp]
        public void Setup()
        {
            goodsClass = new GoodsClass();
        }

        [Test]
        public void GoodsClasses_CategoryWorks()
        {
            //Arrange 
            var category = "Other";
            var selection = new List<GoodsClass>() { new GoodsClass { Category = "Other" },
                 new GoodsClass { Category = "Clothing" },
                 new GoodsClass { Category = "Non-Perishables" } };
            //Act
            var addNewCat = goodsClass.AddNewCategory(category, selection);

            //Assert
            Assert.That(addNewCat, Is.EqualTo(selection.Where(x => x.Category == category)));
        }
    }
}
