using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace ShoppingCart
{
    class Product
    {
        private string name;
        private double price;
        private int quantity;
        private double totalPrice;

        public Product(string inpName, double inpPrice, int inpQuantity)
        {
            name = inpName;
            price = inpPrice;
            quantity = inpQuantity;
            RecalcTotal();
        }

        public double OutTotal()
        {
            return totalPrice;
        }

        public string getName()
        {
            return name;
        }

        public double getPrice()
        {
            return price;
        }

        public double getTotalPrice()
        {
            return totalPrice;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public void AddQuantity()
        {
            quantity++;
            RecalcTotal();
        }

        public void RecalcTotal()
        {
            totalPrice = price * quantity;
        }

        public double GetProduct()
        {
            double Actresult = 0.00;
            var url = "https://equalexperts.github.io/backend-take-home-test-data/cheerios.json";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);


            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();

                Debug.WriteLine(result);

                string[] parts = result.Split(' ');

                Debug.WriteLine("0:"+ parts[0]);
                Debug.WriteLine("1:" + parts[1]);
                Debug.WriteLine("2:" + parts[2]);
                Debug.WriteLine("3:" + parts[3]);
                Debug.WriteLine("4:" + parts[4]);
                Debug.WriteLine("5:" + parts[5]);
                Debug.WriteLine("6:" + parts[6]);

                Actresult = Convert.ToDouble(parts[6]);
            }

            //Debug.WriteLine(httpResponse.StatusCode);

            return Actresult;
        }
    }
}
