using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Products();
        }
    }

    internal class Products
    {
        public Products()
        {

        }
        public Products(List<Product> products)
        {

        }

        public int[] GetGroupArray(int countPerGroup, string property)
        {
            return new int[] {};
        }
    }

    internal class Product
    {
        public int Id { get; set; }
        public int Cost { get; set; }
    }
}
