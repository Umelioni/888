using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Invoice
    {
        public readonly int account;
        public readonly string customer;
        public readonly string provider;

        public Invoice (int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        private Dictionary<string, int> order = new Dictionary<string, int>();

        public void Add (string article, int quantity)
        {
            if (!order.ContainsKey(article))
                order.Add(article, quantity);
            else
                order[article] += quantity;
        }
        public void Down(string article, int quantity)
        {
            if (order.ContainsKey(article)) {
                int lastQuantity = order[article];
                int newQuantity = lastQuantity - quantity;
                if (newQuantity <= 0)
                    Delete(article);
                else
                    order[article] = newQuantity;
            }
        }
        public void Delete(string article)
        {
            order.Remove(article);
        }
        public float GetPrice (bool includeVAT)
        {
            if (order.Count == 0)
                return 0;
            float totalPriceWithoutVAT = 0;
            foreach (var item in order)
                totalPriceWithoutVAT += Database.GetPriceByArticle(item.Key) * item.Value;
            return !includeVAT ? totalPriceWithoutVAT : (totalPriceWithoutVAT * 1.2f);
        }


    }
}
