using System;
using System.Diagnostics;

namespace ShoppingCart
{


    class Program
    {

        static void Main(string[] args)
        {
            Product cornflakes = new Product("Cornflakes", 5.06, 7);
            Debug.WriteLine(cornflakes.OutTotal());

            Basket ShoppingCart = new Basket();
            ShoppingCart.AddItem(cornflakes);

            cornflakes.AddQuantity();
            Debug.WriteLine(cornflakes.OutTotal());

            ShoppingCart.OutItems();

            Product cheerios = new Product("Cheerios", 3.01, 3);
            ShoppingCart.AddItem(cheerios);
            ShoppingCart.OutItems();

            cheerios.GetProduct();
        }
    }
}
