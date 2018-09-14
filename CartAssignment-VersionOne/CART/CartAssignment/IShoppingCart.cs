using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartAssignment
{
    interface IShoppingCart
    {
        void AddToCart(Cart cart, Item itemObj, int NoOfItems);

        void RemoveFromCart(Cart cart, int ID);

        void EmptyCart(Cart cart);

        void ShowCart(Cart cart);

        void TotalBill(Cart cart);
            
        
    }


}
