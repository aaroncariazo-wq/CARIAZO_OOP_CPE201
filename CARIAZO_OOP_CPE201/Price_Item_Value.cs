using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARIAZO_OOP_CPE201
{
    internal class Price_Item_Value
    {
        public String price, itemname, discount_amount;

        public void SetPriceItemValue(string item_price,string item_name)
        {
            this.price = item_price;
            this.itemname = item_name;
        }

        public String GetItemName()
        {
            return itemname;
        }
        public String GetPrice()
        {
            return price;
        }

        public void SetPriceDiscountAmountValue(string discount_amount, string priceItem)
        {
            this.price = priceItem;
            this.discount_amount = discount_amount;
        }
        public String GetPriceItem()
        {
            return price;
        }
        public String GetDiscountAmount()
        {
            return discount_amount;
        }   
    }
}
