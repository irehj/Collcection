using System;
using System.Collections.Generic;

namespace CollectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> categories = new List<string>();
            categories.Add("bag");
            categories.Add("shoes");
            categories.Add("wallet");
            foreach (var category in categories)
            {
                Console.WriteLine(category);
            }
            for (int i = 2; i <= 9; i++)
            {
                for (int j= 1; j <= 9; j++)
                {
                    Console.Write(i + "x" + j + "=" + (i * j) + "\t");
                }
                Console.WriteLine();
                Console.WriteLine(categories[1]);

            }
            #region Dictionary
            Dictionary<string, string> products = new Dictionary<string, string>();

            products.Add("가방", "숄더백");
            products.Add("신발", "나이키");
            products.Add("바지", "리바이스");

            Console.WriteLine(products["신발"]);
            foreach (var product in products)
            {
                Console.WriteLine(product.Key + ":" + product.Value);
            }

            #endregion
        }
    }
}
