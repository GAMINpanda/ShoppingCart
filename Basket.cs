using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ShoppingCart
{
    class Basket
    {
        private List<Product> contents;
        private double totalPriceBasket;
        private double VAT;

        public Basket()
        {
            contents = new List<Product>();
        }

        public void AddItem(Product product)
        {
            contents.Add(product);
            Debug.WriteLine("Item "+ product.getName() +" has been added");
        }

        public void OutItems()
        {
            totalPriceBasket = 0;
            foreach (Product item in contents)
            {
                Debug.WriteLine("{0} x {1} @ £{2} each for a total of £{3}", item.getName(), item.getQuantity(), item.getPrice(), item.getTotalPrice());
                totalPriceBasket = item.getTotalPrice() + totalPriceBasket;
            }

            VAT = totalPriceBasket * 0.125;
            Debug.WriteLine("Subtotal £{0}", totalPriceBasket);
            Debug.WriteLine("£{0} VAT", VAT);
            Debug.WriteLine("For a total of £{0}", (totalPriceBasket + VAT));
        }

    }
}
