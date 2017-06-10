using System;
using System.Collections.Generic;
using System.Linq;
using ExpectedObjects;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDDay1.Tests
{
    [TestClass()]
    public class ProductsTests
    {
        private List<Product> _productList = new List<Product>()
        {
            new Product()  { Id=1,Cost=10},
            new Product()  { Id=1,Cost=12},
            new Product()  { Id=1,Cost=14},
            new Product()  { Id=1,Cost=16},
            new Product()  { Id=1,Cost=18},
            new Product()  { Id=1,Cost=19},
            new Product()  { Id=1,Cost=19},
            new Product()  { Id=1,Cost=19},
            new Product()  { Id=1,Cost=19},
            new Product()  { Id=1,Cost=19},
            new Product()  { Id=1,Cost=20}
        };

        [TestMethod()]
        public void GetGroupArray_countPerGroup_is_3_property_is_Cost_ShouldEqualExpected()
        {
            var products = new Products(new List<Product>());
            var countPerGroup = 3;
            var property = "Cost";
            var expected = new int[] { 36, 53, 57, 39 };

            var actual = products.GetGroupArray(countPerGroup, property);

            expected.ToExpectedObject().ShouldEqual(actual);

        }
        [TestMethod()]
        public void GetGroupArray_countPerGroup_is_11_property_is_Cost_ShouldEqualExpected()
        {
            var products = new Products(new List<Product>());
            var countPerGroup = 3;
            var property = "Cost";
            var expected = new int[] { 185 };

            var actual = products.GetGroupArray(countPerGroup, property);

            expected.ToExpectedObject().ShouldEqual(actual);

        }

        [TestMethod()]
        public void GetGroupArray_countPerGroup_is_12_property_is_Cost_ShouldEqualExpected()
        {
            var products = new Products(new List<Product>());
            var countPerGroup = 3;
            var property = "Cost";
            var expected = new int[] { 185 };

            var actual = products.GetGroupArray(countPerGroup, property);

            expected.ToExpectedObject().ShouldEqual(actual);

        }


        [TestMethod()]
        public void GetGroupArray_countPerGroup_is_0_property_is_Cost_Throw_ArgumentExecption()
        {
            var products = new Products(new List<Product>());
            var countPerGroup = 3;
            var property = "Cost";

            Action action = () => products.GetGroupArray(countPerGroup, property); 
            action.ShouldThrow<ArgumentException>();
        }

        [TestMethod()]
        public void GetGroupArray_countPerGroup_is_3_property_is_NonExist_Throw_ArgumentExecption()
        {
            var products = new Products(new List<Product>());
            var countPerGroup = 3;
            var property = "NonExist";

            Action action = () => products.GetGroupArray(countPerGroup, property);
            action.ShouldThrow<ArgumentException>();
        }
    }


}