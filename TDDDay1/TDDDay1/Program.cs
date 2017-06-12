using System.Collections;

namespace TDDDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Items();
        }
    }

    internal class Items
    {
        public Items()
        {

        }
        public Items(IEnumerable items)
        {

        }

        public int[] GetGroupingSumArray(int countPerGroup, string property)
        {
            return new int[] {};
        }
    }

    internal class Product
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }
    }
}
