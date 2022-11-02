using StoreFront.DATA.EF.Models;
using StoreFront.UI.MVC.Models;

namespace StoreFront.UI.MVC.Models
{
    public class CartItemViewModel
    {
        public int Qty { get; set; }
        public Product CartProd { get; set; }

        public CartItemViewModel() { }

        public CartItemViewModel(int qty, Product product)
        {
            Qty = qty;
            CartProd = product;
        }

    }
}


