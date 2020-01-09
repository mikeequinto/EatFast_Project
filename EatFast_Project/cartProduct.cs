using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatFast_Project
{
    class CartProduct
    {
        private int id;
        private string name;
        private decimal price;
        private int quantity;

        public CartProduct(int id, string name, decimal price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = 1;
        }

        public void add()
        {
            this.quantity = this.quantity + 1;
        }

        public void subtract()
        {
            this.quantity = this.quantity - 1;
        }

        public int getId()
        {
            return this.id;
        }

        public string getName()
        {
            return this.name;
        }

        public decimal getPrice()
        {
            return this.price;
        }

        public int getQuantity()
        {
            return this.quantity;
        }

        public override bool Equals(object value)
        {
            CartProduct product = value as CartProduct;
            return (product != null)
                && (this.id == product.getId());
        }

    }
}
