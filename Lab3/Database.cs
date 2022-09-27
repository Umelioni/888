using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    static class Database
    {
        private static Dictionary<string, float> pricesWithoutVAT = new Dictionary<string, float>();

        public static void InitializeDatabase()
        {
            pricesWithoutVAT = new Dictionary<string, float>()
            {
                { "MARGARITA", 8.0f },
                { "PROSCIUTTO", 8.80f },
                { "NAPOLITANA", 9.20f },
                { "PUTTANESCA", 9.10f },
                { "PICCOLI", 10.10f },
            };
        }
        public static void AddArticle(string article, float price)
        {
            if (!pricesWithoutVAT.ContainsKey(article) && price > 0)
                pricesWithoutVAT.Add(article, price);
        }
        public static void RemoveArticle(string article)
        {
            if (pricesWithoutVAT.ContainsKey(article))
                pricesWithoutVAT.Remove(article);
        }
        public static float GetPriceByArticle(string article)
        {
            float price;
            if (pricesWithoutVAT.TryGetValue(article, out price))
                return price;
            else throw new KeyNotFoundException("This article is not contained in the database");
        }
    }
}
