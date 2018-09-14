using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> stock = new List<Item>
            {
                new Item() { itemID =1, itemName = "Basketball", itemPrice = 500 },
                new Item() { itemID =2, itemName = "Laptop", itemPrice = 35000 },
                new Item() { itemID =3, itemName = "Phone-Cover", itemPrice = 100 },
                new Item() { itemID =4, itemName = "Notebook", itemPrice = 200 },
            };
             Item ItemObj = new Item();
            IShoppingCart cartObj = new CartOperations();
            Cart cart = new Cart();
            while(true) //OUTER MENU IN CONSOLE
            {
                Console.WriteLine("Press 1 to show items\npress 2 to show/add/remove items in cart\npress 3 for Total Bill\n press 4 to exit");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (input == 1)
                {
                    for(int index = 0; index < stock.Count; index++)
                    {
                        Console.WriteLine("ID: "+stock[index].itemID+"  Name: "+stock[index].itemName+" Price: "+stock[index].itemPrice );
                    }
                    while(true)
                    {
                        Console.WriteLine("\nEnter ID of the item you want in cart\nEnter -1 to exit\n");   //INNER MENU IN CONSOLE

                        int itemIDInput = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        if (itemIDInput==-1)
                        {
                            break;
                        }

                        Console.WriteLine("Enter Quantity of the item you want in cart\n-1 to exit\n"); //INNER MENU IN CONSOLE
                        int itemQuantity = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        if (itemQuantity == -1)
                        {
                            break;
                        }

                        cartObj.AddToCart(cart, stock.Find(x => x.itemID == itemIDInput),itemQuantity);
                    }

                }

                else if (input == 2)
                {
                    while (true)
                    {
                        cartObj.ShowCart(cart);
                        Console.WriteLine("Enter 1 to Empty Cart\nEnter 2 to remove an item from Cart\n3 to exit\n"); // INNER MENU IN CONSOLE
                        int CartInput = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        if (CartInput == 1)
                        {
                            cartObj.EmptyCart(cart);
                        }
                        else if (CartInput == 2)
                        {
                            cartObj.ShowCart(cart);
                            Console.WriteLine("Enter ID of object you want to remove\n");           //INNER MENU IN CONSOLE
                            int cartRemoveInput = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            cartObj.RemoveFromCart(cart, cartRemoveInput);
                        }
                        else if (CartInput == 3)
                        {
                            break;
                        }
                    }
                }
                else if(input == 3)
                {
                    cartObj.TotalBill(cart);
                }
                else if (input == 4)
                {
                    break;
                }
            }
            
            
         }
    }
}
