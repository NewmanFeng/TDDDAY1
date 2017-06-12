using System;
using System.Collections.Generic;
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
            new Product() {Id = 1, Cost = 1, Revenue = 11, SellPrice = 21},
            new Product() {Id = 2, Cost = 2, Revenue = 12, SellPrice = 22},
            new Product() {Id = 3, Cost = 3, Revenue = 13, SellPrice = 23},
            new Product() {Id = 4, Cost = 4, Revenue = 14, SellPrice = 24},
            new Product() {Id = 5, Cost = 5, Revenue = 15, SellPrice = 25},
            new Product() {Id = 6, Cost = 6, Revenue = 16, SellPrice = 26},
            new Product() {Id = 7, Cost = 7, Revenue = 17, SellPrice = 27},
            new Product() {Id = 8, Cost = 8, Revenue = 18, SellPrice = 28},
            new Product() {Id = 9, Cost = 9, Revenue = 19, SellPrice = 29},
            new Product() {Id = 10, Cost = 10, Revenue = 20, SellPrice = 30},
            new Product() {Id = 11, Cost = 11, Revenue = 21, SellPrice = 31}
        };

        [TestMethod()]
        public void GetGroupingSumArray_countPerGroup_is_3_property_is_Cost_ShouldEqualExpected()
        {
            var products = new Items(_productList);
            var countPerGroup = 3;
            var property = "Cost";
            var expected = new int[] { 6, 15, 24, 21 };

            var actual = products.GetGroupingSumArray(countPerGroup, property);

            expected.ToExpectedObject().ShouldEqual(actual);

        }

        [TestMethod()]
        public void GetGroupingSumArray_countPerGroup_is_4_property_is_Revenue_ShouldEqualExpected()
        {
            var products = new Items(_productList);
            var countPerGroup = 4;
            var property = "Revenue";
            var expected = new int[] { 50, 66, 60 };

            var actual = products.GetGroupingSumArray(countPerGroup, property);

            expected.ToExpectedObject().ShouldEqual(actual);

        }

        [TestMethod()]
        public void GetGroupingSumArray_countPerGroup_is_11_property_is_Cost_ShouldEqualExpected()
        {
            var products = new Items(_productList);
            var countPerGroup = 11;
            var property = "Cost";
            var expected = new int[] { 185 };

            var actual = products.GetGroupingSumArray(countPerGroup, property);

            expected.ToExpectedObject().ShouldEqual(actual);

        }

        [TestMethod()]
        public void GetGroupingSumArray_countPerGroup_is_12_property_is_Cost_ShouldEqualExpected()
        {
            var products = new Items(_productList);
            var countPerGroup = 12;
            var property = "Cost";
            var expected = new int[] { 185 };

            var actual = products.GetGroupingSumArray(countPerGroup, property);

            expected.ToExpectedObject().ShouldEqual(actual);

        }


        [TestMethod()]
        public void GetGroupingSumArray_countPerGroup_is_0_property_is_Cost_Throw_ArgumentExecption()
        {
            var products = new Items(_productList);
            var countPerGroup = 0;
            var property = "Cost";

            Action action = () => products.GetGroupingSumArray(countPerGroup, property);
            action.ShouldThrow<ArgumentException>();
        }

        [TestMethod()]
        public void GetGroupingSumArray_countPerGroup_is_3_property_is_NonExist_Throw_ArgumentExecption()
        {
            var products = new Items(_productList);
            var countPerGroup = 3;
            var property = "NonExist";

            Action action = () => products.GetGroupingSumArray(countPerGroup, property);
            action.ShouldThrow<ArgumentException>();
        }
    }


}