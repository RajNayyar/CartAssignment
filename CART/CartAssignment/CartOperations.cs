using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartAssignment
{
    class CartOperations : IShoppingCart
    {
        
        public void AddToCart(Cart cart, Item itemObj, int NoOfItems)
        {
            for (int i = 0; i < NoOfItems; i++)
            {
                cart.ItemsInCart.Add(itemObj);
                Console.WriteLine("Item Added succesfully");
            }
        }

        public void RemoveFromCart(Cart cart, int ID)
        {
            if(cart.ItemsInCart.Count<1)
            {
                Console.WriteLine("Cart already Empty\n");
            }
            else
            {
                if (cart.ItemsInCart.Exists(x=>x.itemID==ID))
                {
                    cart.ItemsInCart.Remove(cart.ItemsInCart.Find(x=>x.itemID==ID));
                    Console.WriteLine("Succesfully Removed\n");
                }
                else
                {
                    Console.WriteLine("Item Does not exists\n");
                }
            }
        }

        public void EmptyCart(Cart cart)
        {
            cart.ItemsInCart.Clear();
            Console.WriteLine("Cart Removed Successfully");
        }

        public void ShowCart(Cart cart)
        {
            Console.WriteLine("---------------CART----------------");
            for (int index = 0; index < cart.ItemsInCart.Count; index++)
            {
                Console.WriteLine("ID: " + cart.ItemsInCart[index].itemID + "  Name: " + cart.ItemsInCart[index].itemName + " Price: " + cart.ItemsInCart[index].itemPrice);
            }
            TotalBill(cart);
            Console.WriteLine("-----------------------------------");
        }

        public void TotalBill(Cart cart)
        {
            float bill = 0;
            for(int i=0;i<cart.ItemsInCart.Count;i++)
            {
                bill = bill + cart.ItemsInCart[i].itemPrice;
            }
            Console.WriteLine("Total Amount: "+bill+"\n");
        }

    }
}
